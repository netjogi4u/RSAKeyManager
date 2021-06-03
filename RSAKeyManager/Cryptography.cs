using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

using RSAKeyManager.Model;

namespace RSAKeyManager
{
    class Cryptography
    {
        public event Action<long> ProgressConfigure;
        public event Action ProgressChanged;
        public static Key GenerateKeys(int keySize)
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(keySize);
            Key newKey = new Key() { privateKey = PEM.ExportPrivateKey(rsa), publicKey = PEM.ExportPublicKey(rsa) };
            return newKey;
        }

        public static string Sign(string privateKey, string inputString, string HashAlgo)
        {
            RSACryptoServiceProvider rsa = PEM.ImportPrivateKey(privateKey);
            return Convert.ToBase64String(rsa.SignData(Encoding.ASCII.GetBytes(inputString), getHashingAlgorithm(HashAlgo)));
        }
        public static bool Verify(string publicKey, string inputString, string signature, string HashAlgo)
        {
            RSACryptoServiceProvider rsa = PEM.ImportPublicKey(publicKey);
            return rsa.VerifyData(Encoding.ASCII.GetBytes(inputString), getHashingAlgorithm(HashAlgo), Convert.FromBase64String(signature));
        }

        static object getHashingAlgorithm(string HashingAlgo)
        {
            object Algo = null;
            if (HashingAlgo == "SHA1")
                Algo= SHA1.Create();
            else if (HashingAlgo == "SHA256")
                Algo= SHA256.Create();
            else if (HashingAlgo == "SHA384")
                Algo= SHA384.Create();
            else if (HashingAlgo == "SHA512")
                Algo= SHA512.Create();
            else if (HashingAlgo == "MD5")
                Algo= MD5.Create();
            return Algo;


        }

        public static bool validate(string key, bool isprivate)
        {
            try
            {
                RSACryptoServiceProvider rsa;
                if (isprivate)
                    rsa = PEM.ImportPrivateKey(key);
                else
                    rsa = PEM.ImportPublicKey(key);
                return true;
            }
           catch
            {
                return false;
            }
        }

        public static bool validateInputSize(string inputString, string publickKey, bool OAEPpadding)
        {
            RSACryptoServiceProvider rsa = PEM.ImportPublicKey(publickKey);
            int RSAHeadersize;
            if (OAEPpadding)
                RSAHeadersize = 42;
            else
                RSAHeadersize = 11;
            int room = (rsa.KeySize / 8) - RSAHeadersize;
            if (inputString.Length > room)
                return false;

            return true;
        }
        public static string Encrypt(string publickKey, string inputString, bool OAEPpadding)
        {

            RSACryptoServiceProvider rsa = PEM.ImportPublicKey(publickKey);
            byte[] InputBytes = Encoding.ASCII.GetBytes(inputString);
            int RSAHeadersize;
            if (OAEPpadding)
                RSAHeadersize = 42;
            else
                RSAHeadersize = 11;

            int room = (rsa.KeySize / 8) - RSAHeadersize;
            int remainingBytes = InputBytes.Length;
            int startIndex = 0;
            byte[] outputBytes = new byte[0];
            while (remainingBytes > 0)
            {
                int lengthToEncrypt;
                if (remainingBytes > room)
                    lengthToEncrypt = room;
                else
                    lengthToEncrypt = remainingBytes;

                byte[] block = new byte[lengthToEncrypt];
                Array.Copy(InputBytes, startIndex, block, 0, lengthToEncrypt);
                byte[] encryptedBytes = rsa.Encrypt(block, OAEPpadding);
                byte[] tempBytes = new byte[outputBytes.Length + encryptedBytes.Length];
                if (outputBytes.Length > 0)
                {
                    Array.Copy(outputBytes, 0, tempBytes, 0, outputBytes.Length);
                }
                Array.Copy(encryptedBytes, 0, tempBytes, outputBytes.Length, encryptedBytes.Length);
                outputBytes = tempBytes;
                startIndex += lengthToEncrypt;
                remainingBytes -= lengthToEncrypt;              
            }
            return Convert.ToBase64String(outputBytes);
        }

        public static string decrypt(string privateKey, string Hash, bool OAEPpadding)
        {
            string decryptedText = string.Empty;
            RSACryptoServiceProvider rsa = PEM.ImportPrivateKey(privateKey);
            byte[] inputBytes = Convert.FromBase64String(Hash);
            int room = rsa.KeySize / 8;
            int remainingBytes = inputBytes.Length;
            int startIndex = 0;
            while (remainingBytes > 0)
            {
                int lengthToDencrypt;
                if (remainingBytes > room)
                    lengthToDencrypt = room;
                else
                    lengthToDencrypt = remainingBytes;

                byte[] block = new byte[lengthToDencrypt];
                Array.Copy(inputBytes, startIndex, block, 0, lengthToDencrypt);
                decryptedText += Encoding.ASCII.GetString(rsa.Decrypt(block, OAEPpadding));
                startIndex += lengthToDencrypt;
                remainingBytes -= lengthToDencrypt;
            }
            return decryptedText;
        }

        public void encryptFile(string FileName, string publicKey, bool OAEPpadding)
        {
            using (FileStream stReader = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            {
                using (FileStream stWriter = new FileStream(FileName + ".rsa", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    RSACryptoServiceProvider rsa = PEM.ImportPublicKey(publicKey);
                    int RSAHeadersize;
                    if (OAEPpadding)
                        RSAHeadersize = 42;
                    else
                        RSAHeadersize = 11;

                    int MaxBufferlength = (rsa.KeySize / 8) - RSAHeadersize;
                    long RemainingBytes = stReader.Length;

                    if (ProgressConfigure != null)
                        ProgressConfigure(stReader.Length/ MaxBufferlength);

                    byte[] buff;
                    if (RemainingBytes > MaxBufferlength)
                        buff = new byte[MaxBufferlength];
                    else
                        buff = new byte[RemainingBytes];

                    int bytesread = 0;
                    while ((bytesread = stReader.Read(buff, 0, buff.Length)) > 0)
                    {

                        byte[] buffEncrypted = rsa.Encrypt(buff, OAEPpadding);
                        stWriter.Write(buffEncrypted, 0, buffEncrypted.Length);
                        RemainingBytes = RemainingBytes - bytesread;

                        if (RemainingBytes > MaxBufferlength)
                            buff = new byte[MaxBufferlength];
                        else
                            buff = new byte[RemainingBytes];
                        
                        var eh = ProgressChanged;
                        if (eh != null)
                            ProgressChanged();
                    }
                }
            }
        }

        public void decryptFile(string inputFileName, string outputFileName, string privateKey, bool OAEPpadding)
        {
            using (FileStream stReader = new FileStream(inputFileName, FileMode.Open, FileAccess.Read))
            {
                RSACryptoServiceProvider rsa = PEM.ImportPrivateKey(privateKey);
                int blocksize = rsa.KeySize / 8;
                if (ProgressConfigure != null)
                    ProgressConfigure(stReader.Length/blocksize);

                using (FileStream stWriter = new FileStream(outputFileName, FileMode.OpenOrCreate, FileAccess.Write))
                {                    
                    byte[] buff = new byte[blocksize];
                    while (stReader.Read(buff, 0, buff.Length) > 0)
                    {
                        byte[] buffDencrypted = rsa.Decrypt(buff, OAEPpadding);
                        stWriter.Write(buffDencrypted, 0, buffDencrypted.Length);
                        buff = new byte[blocksize];

                        if (ProgressChanged != null)
                            ProgressChanged();
                    }
                }
            }
        }
    }
}

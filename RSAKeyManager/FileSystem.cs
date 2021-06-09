using System.IO;
using System.Security.Cryptography;
using RSAKeyManager.Model;

namespace RSAKeyManager
{
    public class FileSystem
    {
        public static Key ReadPrivateKey(Stream FileStream)
        {
            Key myKey = new Key();
            using (FileStream)
            {
                using (StreamReader reader = new StreamReader(FileStream))
                {
                    myKey.privateKey = reader.ReadToEnd();
                    RSACryptoServiceProvider csp = PEM.ImportPrivateKey(myKey.privateKey);
                    myKey.publicKey = PEM.ExportPublicKey(PEM.ImportPrivateKey(myKey.privateKey));
                    myKey.keySize = csp.KeySize;
                }
            }
            return myKey;
        }

        public static string ReadPublicKey(Stream fileStream)
        {
            string publicKey = string.Empty;
            using ( fileStream )
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    publicKey = reader.ReadToEnd();                    
                }
            }
            return publicKey;
        }

        public static void writeKey(string fileName, string[] Key)
        {
            File.WriteAllLines(fileName, Key);
        }
        
    }
}

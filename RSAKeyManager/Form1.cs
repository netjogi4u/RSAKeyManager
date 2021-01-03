using RSAKeyManager.Model;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAKeyManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKeySize.SelectedIndex = 2;
            generateKeys();
        }

        void setButtonState(bool state)
        {
            btnDecrypt.Enabled = state;
            btnDecryptFile.Enabled = state;
            btnEncrypt.Enabled = state;
            btnEncryptFile.Enabled = state;
            btnExportPrivate.Enabled = state;
            btnExportPublic.Enabled = state;
            btnGenerate.Enabled = state;
            btnImportPrivateKey.Enabled = state;
            btnImportPublicKey.Enabled = state;
            btnSign.Enabled = state;
            btnVerify.Enabled = state;            
        }

        void setStatus(string statusMessage)
        {
            tsStatus.Text = statusMessage;           
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generateKeys();
        }

        async void generateKeys()
        {
            try
            {
                setButtonState(false);
                setStatus("Generating key.");
                txtPrivateKey.Text = txtPublicKey.Text = string.Empty;
                txtPrivateKey.Text = txtPublicKey.Text = "Generating keys, Pleae wait ....... !";
                int keysize = Convert.ToInt16(cmbKeySize.SelectedItem);
                Key RSAKey = await Task.Run(() => Cryptography.GenerateKeys(keysize));
                txtPrivateKey.Text = RSAKey.privateKey;
                txtPublicKey.Text = RSAKey.publicKey;
                setStatus("Key Generated.");
                setButtonState(true);
            }
            catch (Exception ex)
            {
                setButtonState(true);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPrivateKey.Text))
                {
                    MessageBox.Show("Private key not available");
                    return;
                }
                else if (string.IsNullOrEmpty(txtInputString.Text))
                {
                    MessageBox.Show("Input string cannot be empty");
                    return;
                }

                else
                {
                    txtHash.Text =  Cryptography.Sign(txtPrivateKey.Text, txtInputString.Text);
                    setStatus("Signature generated");
                }
                   
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPublicKey.Text))
                {
                    MessageBox.Show("Public key not available");
                    return;
                }
                else if (string.IsNullOrEmpty(txtHash.Text))
                {
                    MessageBox.Show("Signature cannot be empty");
                    return;
                }
                else if (string.IsNullOrEmpty(txtInputString.Text))
                {
                    MessageBox.Show("input string cannot be empty");
                    return;
                }
                if (Cryptography.Verify(txtPublicKey.Text, txtInputString.Text, txtHash.Text))
                    setStatus("Success !!! provided signature cryptographically matches with the text.");

                else
                    setStatus("Failed !!! provided signature doest not cryptographically match with the text.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPublicKey.Text))
                {
                    MessageBox.Show("Public key not available");
                    return;
                }
                else if (string.IsNullOrEmpty(txtInputString.Text))
                {
                    MessageBox.Show("Input string cannot be empty");
                    return;
                }
                else if (chkOverflow.Checked == false && Cryptography.validateInputSize(txtInputString.Text,txtPublicKey.Text,chkOAEPPedding.Checked) == false)
                {
                    MessageBox.Show("Length of input string is greater than allowed lengh by selected Key size, either check overflow or uncheck OAEP padding or use higer key size.");
                    return;
                }    
                txtHash.Text = string.Empty;
                txtHash.Text = Cryptography.Encrypt(txtPublicKey.Text, txtInputString.Text, chkOAEPPedding.Checked);
                setStatus("Text encrypted.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPrivateKey.Text))
                {
                    MessageBox.Show("Private key not available");
                    return;
                }
                else if (string.IsNullOrEmpty(txtHash.Text))
                {
                    MessageBox.Show("Ecrypted string cannot be empty");
                    return;
                }
                txtInputString.Text = string.Empty;
                txtInputString.Text = Cryptography.decrypt(txtPrivateKey.Text, txtHash.Text, chkOAEPPedding.Checked);
                setStatus("Cypher text decrypted.");
            }
            catch(CryptographicException cex)
            {
                MessageBox.Show("Private key used is not correct.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnExportPrivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPrivateKey.Text))
                {
                    MessageBox.Show("Private key not available");
                    return;
                }
                else if (!Cryptography.validate(txtPrivateKey.Text,true))
                {
                    MessageBox.Show("Private key is not valid.");
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PEM files (*.pem)|*.pem|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.AddExtension = true;
                    sfd.RestoreDirectory = true;
                    sfd.DefaultExt = "txt";
                    sfd.FileName = "RSAPrivateKey";
                    DialogResult result = sfd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(sfd.FileName))
                    {
                        string filename = sfd.FileName;
                        string[] privatekey = txtPrivateKey.Lines;
                        setButtonState(false);
                        setStatus("Exporting private key.");
                        await Task.Run(() => FileSystem.writeKey(filename, privatekey));
                        setStatus("Private key exported.");
                        setButtonState(true);
                    }
                }

            }
            catch (Exception ex)
            {
                setButtonState(true);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnExportPublic_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPublicKey.Text))
                {
                    MessageBox.Show("Public key not available");
                    return;
                }
                else if (!Cryptography.validate(txtPublicKey.Text, false))
                {
                    MessageBox.Show("Public key is not valid.");
                    return;
                }
                using (SaveFileDialog sfd = new SaveFileDialog())
                {

                    sfd.Filter = "PEM files (*.pem)|*.pem|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.AddExtension = true;
                    sfd.RestoreDirectory = true;
                    sfd.DefaultExt = "txt";
                    sfd.FileName = "RSAPublicKey";

                    DialogResult result = sfd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(sfd.FileName))
                    {
                        string filename = sfd.FileName;
                        string[] publicKey = txtPublicKey.Lines;
                        setButtonState(false);
                        setStatus("Exporting public key.");
                        await Task.Run(() => FileSystem.writeKey(filename, publicKey));
                        setStatus("Public key exported..");
                        setButtonState(true);
                    }
                }


            }
            catch (Exception ex)
            {
                setButtonState(true);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportPrivateKey_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "PEM files (*.pem)|*.pem|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    ofd.RestoreDirectory = true;

                    DialogResult result = ofd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                    {
                        try
                        {
                            Key myKey = FileSystem.ReadPrivateKey(ofd.OpenFile());
                            txtPrivateKey.Text = myKey.privateKey;
                            txtPublicKey.Text = myKey.publicKey;
                            setStatus("Private key imported.");
                        }
                        catch
                        {
                            MessageBox.Show("Pivate key is not valid.");
                        }
                       
                        
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportPublicKey_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "PEM files (*.pem)|*.pem|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    ofd.RestoreDirectory = true;
                    DialogResult result = ofd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                    {
                        try
                        {
                            txtPublicKey.Text = FileSystem.ReadPublicKey(ofd.OpenFile());
                            txtPrivateKey.Text = string.Empty;
                            setStatus("Public key imported.");
                        }
                        catch
                        {
                            MessageBox.Show("public key is not valid.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnEncryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPublicKey.Text))
                {
                    MessageBox.Show("Public key not available");
                    return;
                }                
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All files (*.*)|*.*";
                ofd.RestoreDirectory = true;
                DialogResult ofdResult = ofd.ShowDialog();
                if (ofdResult == DialogResult.OK)
                {
                    bool OAEPpadding = chkOAEPPedding.Checked;
                    string publicKey = txtPublicKey.Text;
                    setButtonState(false);
                    setStatus("Encrypting file.(Note: The greater the key size the slower the ecryption process will be.)");
                    Cryptography mycrypto = new Cryptography();
                    mycrypto.ProgressConfigure += Mycrypto_ProgressConfigure;
                    mycrypto.ProgressChanged += Mycrypto_ProgressChanged;
                    await Task.Run(() => mycrypto.encryptFile(ofd.FileName, publicKey, OAEPpadding));
                    setStatus("File encryption completed.");
                    setButtonState(true);
                }
            }
            catch (Exception ex)
            {
                setButtonState(true);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mycrypto_ProgressConfigure(long Max)
        {
            pgProgress.Minimum = 0;
            Invoke(new Action(() => pgProgress.Maximum = Convert.ToInt32(Max))) ;
            Invoke(new Action(() => pgProgress.Value = 0)) ;
            
        }

        private void Mycrypto_ProgressChanged()
        {
           Invoke(new Action(() => pgProgress.Increment(1))) ;
        }

        private async void btnDecryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPrivateKey.Text))
                {
                    MessageBox.Show("Private key not available");
                    return;
                }
                
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "RSA files (*.rsa)|*.rsa|All files (*.*)|*.*";
                ofd.RestoreDirectory = true;
                DialogResult ofdResult = ofd.ShowDialog();
                if (ofdResult == DialogResult.OK)
                {
                    string outputFileName = ofd.FileName.Substring(0, ofd.FileName.Length - 4);
                    FileInfo fi = new FileInfo(outputFileName);
                    outputFileName = fi.DirectoryName +  @"\d_" + fi.Name;
                    bool FlagAllowWrite = true;
                    if (File.Exists(outputFileName))
                    {
                        DialogResult dr = MessageBox.Show(string.Format("File {0} already exists, do you want to overwrite the file ?", outputFileName), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.No)
                            FlagAllowWrite = false;
                    }
                    if (FlagAllowWrite)
                    {
                        bool OAEPpadding = chkOAEPPedding.Checked;
                        string privateKey = txtPrivateKey.Text;
                        setButtonState(false);
                        setStatus("Decrypting file. (Note: The greater the key size the slower the decryption process will be.)");
                        Cryptography mycrypto = new Cryptography();
                        mycrypto.ProgressConfigure += Mycrypto_ProgressConfigure;
                        mycrypto.ProgressChanged += Mycrypto_ProgressChanged;
                        await Task.Run(() => mycrypto.decryptFile(ofd.FileName, outputFileName, privateKey, OAEPpadding));
                        setStatus("File decryption completed.");
                        setButtonState(true);                        
                    }
                }
            }
            catch(CryptographicException cex)
            {
                setButtonState(true);
                MessageBox.Show("Private key used is not correct.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                setButtonState(true);
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyPrivateKey_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrivateKey.Text))
            {
                Clipboard.SetText(txtPrivateKey.Text);
                setStatus("Private key copied to clipboard.");
            }
           
        }

        private void btnPastePrivateKey_Click(object sender, EventArgs e)
        {
            string txtClipboard = Clipboard.GetText();
            if(!string.IsNullOrEmpty(txtClipboard))
            {
                txtPrivateKey.Text = txtClipboard;
                setStatus("Private key copied from clipboard.");
            }

        }

        private void btnCopyPublicKey_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPublicKey.Text))
            {
                Clipboard.SetText(txtPublicKey.Text);
                setStatus("Public key copied to clipboard.");
            }           
        }

        private void btnPastePublicKey_Click(object sender, EventArgs e)
        {
            string txtClipboard = Clipboard.GetText();
            if (!string.IsNullOrEmpty(txtClipboard))
            {
                txtPublicKey.Text = txtClipboard;
                setStatus("Public key copied from clipboard.");
            }
            
        }

        private void btnCopyText_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInputString.Text))
            {
                Clipboard.SetText(txtInputString.Text);
                setStatus("Text copied to clipboard.");
            }
            
        }

        private void btnPasteText_Click(object sender, EventArgs e)
        {
            string txtClipboard = Clipboard.GetText();
            if (!string.IsNullOrEmpty(txtClipboard))
            {
                txtInputString.Text = txtClipboard;
                setStatus("Text copied from clipboard.");
            }
        }

        private void btnCopyHash_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHash.Text))
            {
                Clipboard.SetText(txtHash.Text);
                setStatus("Cypter/signature copied to clipboard.");
            }
               
        }

        private void btnPasteHash_Click(object sender, EventArgs e)
        {
            string txtClipboard = Clipboard.GetText();
            if (!string.IsNullOrEmpty(txtClipboard))
            {
                txtHash.Text = txtClipboard;
                setStatus("Cypher copied from clipboard.");
            }
        }
    }
}

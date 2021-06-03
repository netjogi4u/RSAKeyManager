
namespace RSAKeyManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPublicKey = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbKeySize = new System.Windows.Forms.ComboBox();
            this.txtPrivateKey = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPasteHash = new System.Windows.Forms.Button();
            this.btnCopyHash = new System.Windows.Forms.Button();
            this.btnPasteText = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopyText = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkOverflow = new System.Windows.Forms.CheckBox();
            this.chkOAEPPedding = new System.Windows.Forms.CheckBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnExportPrivate = new System.Windows.Forms.Button();
            this.btnExportPublic = new System.Windows.Forms.Button();
            this.btnImportPrivateKey = new System.Windows.Forms.Button();
            this.btnImportPublicKey = new System.Windows.Forms.Button();
            this.btnCopyPrivateKey = new System.Windows.Forms.Button();
            this.btnPastePrivateKey = new System.Windows.Forms.Button();
            this.btnPastePublicKey = new System.Windows.Forms.Button();
            this.btnCopyPublicKey = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.chkLinefeed = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicKey.Location = new System.Drawing.Point(734, 92);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(708, 453);
            this.txtPublicKey.TabIndex = 1;
            this.txtPublicKey.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Private Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Public Key";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(161, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(143, 37);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbKeySize
            // 
            this.cmbKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKeySize.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "3072",
            "4096"});
            this.cmbKeySize.Location = new System.Drawing.Point(12, 12);
            this.cmbKeySize.Name = "cmbKeySize";
            this.cmbKeySize.Size = new System.Drawing.Size(143, 33);
            this.cmbKeySize.TabIndex = 5;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivateKey.Location = new System.Drawing.Point(12, 92);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(708, 453);
            this.txtPrivateKey.TabIndex = 0;
            this.txtPrivateKey.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.chkLinefeed);
            this.groupBox1.Controls.Add(this.btnPasteHash);
            this.groupBox1.Controls.Add(this.btnCopyHash);
            this.groupBox1.Controls.Add(this.btnPasteText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCopyText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkOverflow);
            this.groupBox1.Controls.Add(this.chkOAEPPedding);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.btnVerify);
            this.groupBox1.Controls.Add(this.btnSign);
            this.groupBox1.Controls.Add(this.txtHash);
            this.groupBox1.Controls.Add(this.txtInputString);
            this.groupBox1.Location = new System.Drawing.Point(12, 551);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1430, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign and Verify TEXT";
            // 
            // btnPasteHash
            // 
            this.btnPasteHash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasteHash.BackgroundImage")));
            this.btnPasteHash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasteHash.Location = new System.Drawing.Point(1384, 79);
            this.btnPasteHash.Name = "btnPasteHash";
            this.btnPasteHash.Size = new System.Drawing.Size(33, 30);
            this.btnPasteHash.TabIndex = 21;
            this.btnPasteHash.UseVisualStyleBackColor = true;
            this.btnPasteHash.Click += new System.EventHandler(this.btnPasteHash_Click);
            // 
            // btnCopyHash
            // 
            this.btnCopyHash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyHash.BackgroundImage")));
            this.btnCopyHash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyHash.Location = new System.Drawing.Point(1348, 79);
            this.btnCopyHash.Name = "btnCopyHash";
            this.btnCopyHash.Size = new System.Drawing.Size(33, 30);
            this.btnCopyHash.TabIndex = 20;
            this.btnCopyHash.UseVisualStyleBackColor = true;
            this.btnCopyHash.Click += new System.EventHandler(this.btnCopyHash_Click);
            // 
            // btnPasteText
            // 
            this.btnPasteText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasteText.BackgroundImage")));
            this.btnPasteText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasteText.Location = new System.Drawing.Point(1384, 21);
            this.btnPasteText.Name = "btnPasteText";
            this.btnPasteText.Size = new System.Drawing.Size(33, 30);
            this.btnPasteText.TabIndex = 19;
            this.btnPasteText.UseVisualStyleBackColor = true;
            this.btnPasteText.Click += new System.EventHandler(this.btnPasteText_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Text to Decrypt/Verify";
            // 
            // btnCopyText
            // 
            this.btnCopyText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyText.BackgroundImage")));
            this.btnCopyText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyText.Location = new System.Drawing.Point(1348, 21);
            this.btnCopyText.Name = "btnCopyText";
            this.btnCopyText.Size = new System.Drawing.Size(33, 30);
            this.btnCopyText.TabIndex = 18;
            this.btnCopyText.UseVisualStyleBackColor = true;
            this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Text to Encrypt/Sign";
            // 
            // chkOverflow
            // 
            this.chkOverflow.AutoSize = true;
            this.chkOverflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOverflow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chkOverflow.Location = new System.Drawing.Point(832, 119);
            this.chkOverflow.Name = "chkOverflow";
            this.chkOverflow.Size = new System.Drawing.Size(111, 29);
            this.chkOverflow.TabIndex = 14;
            this.chkOverflow.Text = "Overflow";
            this.chkOverflow.UseVisualStyleBackColor = true;
            // 
            // chkOAEPPedding
            // 
            this.chkOAEPPedding.AutoSize = true;
            this.chkOAEPPedding.Checked = true;
            this.chkOAEPPedding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOAEPPedding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOAEPPedding.ForeColor = System.Drawing.Color.Maroon;
            this.chkOAEPPedding.Location = new System.Drawing.Point(221, 119);
            this.chkOAEPPedding.Name = "chkOAEPPedding";
            this.chkOAEPPedding.Size = new System.Drawing.Size(167, 29);
            this.chkOAEPPedding.TabIndex = 13;
            this.chkOAEPPedding.Text = "OAEP Padding";
            this.chkOAEPPedding.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.Maroon;
            this.btnDecrypt.Location = new System.Drawing.Point(1098, 115);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(143, 37);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEncrypt.Location = new System.Drawing.Point(949, 115);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(143, 37);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.Maroon;
            this.btnVerify.Location = new System.Drawing.Point(586, 115);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(143, 37);
            this.btnVerify.TabIndex = 8;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.Color.Maroon;
            this.btnSign.Location = new System.Drawing.Point(437, 115);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(143, 37);
            this.btnSign.TabIndex = 7;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtHash
            // 
            this.txtHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHash.Location = new System.Drawing.Point(221, 79);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(1120, 30);
            this.txtHash.TabIndex = 1;
            // 
            // txtInputString
            // 
            this.txtInputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputString.Location = new System.Drawing.Point(221, 21);
            this.txtInputString.Multiline = true;
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputString.Size = new System.Drawing.Size(1120, 52);
            this.txtInputString.TabIndex = 0;
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptFile.ForeColor = System.Drawing.Color.Maroon;
            this.btnDecryptFile.Location = new System.Drawing.Point(1296, 12);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(143, 37);
            this.btnDecryptFile.TabIndex = 12;
            this.btnDecryptFile.Text = "Decrypt File";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptFile.ForeColor = System.Drawing.Color.Maroon;
            this.btnEncryptFile.Location = new System.Drawing.Point(1147, 12);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(143, 37);
            this.btnEncryptFile.TabIndex = 11;
            this.btnEncryptFile.Text = "Encrypt File";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // btnExportPrivate
            // 
            this.btnExportPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPrivate.Location = new System.Drawing.Point(214, 56);
            this.btnExportPrivate.Name = "btnExportPrivate";
            this.btnExportPrivate.Size = new System.Drawing.Size(143, 33);
            this.btnExportPrivate.TabIndex = 7;
            this.btnExportPrivate.Text = "Export";
            this.btnExportPrivate.UseVisualStyleBackColor = true;
            this.btnExportPrivate.Click += new System.EventHandler(this.btnExportPrivate_Click);
            // 
            // btnExportPublic
            // 
            this.btnExportPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPublic.Location = new System.Drawing.Point(918, 56);
            this.btnExportPublic.Name = "btnExportPublic";
            this.btnExportPublic.Size = new System.Drawing.Size(143, 33);
            this.btnExportPublic.TabIndex = 8;
            this.btnExportPublic.Text = "Export";
            this.btnExportPublic.UseVisualStyleBackColor = true;
            this.btnExportPublic.Click += new System.EventHandler(this.btnExportPublic_Click);
            // 
            // btnImportPrivateKey
            // 
            this.btnImportPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportPrivateKey.Location = new System.Drawing.Point(363, 56);
            this.btnImportPrivateKey.Name = "btnImportPrivateKey";
            this.btnImportPrivateKey.Size = new System.Drawing.Size(143, 33);
            this.btnImportPrivateKey.TabIndex = 9;
            this.btnImportPrivateKey.Text = "Import";
            this.btnImportPrivateKey.UseVisualStyleBackColor = true;
            this.btnImportPrivateKey.Click += new System.EventHandler(this.btnImportPrivateKey_Click);
            // 
            // btnImportPublicKey
            // 
            this.btnImportPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportPublicKey.Location = new System.Drawing.Point(1067, 56);
            this.btnImportPublicKey.Name = "btnImportPublicKey";
            this.btnImportPublicKey.Size = new System.Drawing.Size(143, 33);
            this.btnImportPublicKey.TabIndex = 10;
            this.btnImportPublicKey.Text = "Import";
            this.btnImportPublicKey.UseVisualStyleBackColor = true;
            this.btnImportPublicKey.Click += new System.EventHandler(this.btnImportPublicKey_Click);
            // 
            // btnCopyPrivateKey
            // 
            this.btnCopyPrivateKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyPrivateKey.BackgroundImage")));
            this.btnCopyPrivateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyPrivateKey.Location = new System.Drawing.Point(136, 57);
            this.btnCopyPrivateKey.Name = "btnCopyPrivateKey";
            this.btnCopyPrivateKey.Size = new System.Drawing.Size(33, 30);
            this.btnCopyPrivateKey.TabIndex = 14;
            this.btnCopyPrivateKey.UseVisualStyleBackColor = true;
            this.btnCopyPrivateKey.Click += new System.EventHandler(this.btnCopyPrivateKey_Click);
            // 
            // btnPastePrivateKey
            // 
            this.btnPastePrivateKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPastePrivateKey.BackgroundImage")));
            this.btnPastePrivateKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPastePrivateKey.Location = new System.Drawing.Point(175, 57);
            this.btnPastePrivateKey.Name = "btnPastePrivateKey";
            this.btnPastePrivateKey.Size = new System.Drawing.Size(33, 30);
            this.btnPastePrivateKey.TabIndex = 15;
            this.btnPastePrivateKey.UseVisualStyleBackColor = true;
            this.btnPastePrivateKey.Click += new System.EventHandler(this.btnPastePrivateKey_Click);
            // 
            // btnPastePublicKey
            // 
            this.btnPastePublicKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPastePublicKey.BackgroundImage")));
            this.btnPastePublicKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPastePublicKey.Location = new System.Drawing.Point(879, 57);
            this.btnPastePublicKey.Name = "btnPastePublicKey";
            this.btnPastePublicKey.Size = new System.Drawing.Size(33, 30);
            this.btnPastePublicKey.TabIndex = 17;
            this.btnPastePublicKey.UseVisualStyleBackColor = true;
            this.btnPastePublicKey.Click += new System.EventHandler(this.btnPastePublicKey_Click);
            // 
            // btnCopyPublicKey
            // 
            this.btnCopyPublicKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyPublicKey.BackgroundImage")));
            this.btnCopyPublicKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyPublicKey.Location = new System.Drawing.Point(840, 57);
            this.btnCopyPublicKey.Name = "btnCopyPublicKey";
            this.btnCopyPublicKey.Size = new System.Drawing.Size(33, 30);
            this.btnCopyPublicKey.TabIndex = 16;
            this.btnCopyPublicKey.UseVisualStyleBackColor = true;
            this.btnCopyPublicKey.Click += new System.EventHandler(this.btnCopyPublicKey_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus,
            this.pgProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1456, 26);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.AutoSize = false;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(800, 21);
            this.tsStatus.Text = "Ready";
            this.tsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pgProgress
            // 
            this.pgProgress.Name = "pgProgress";
            this.pgProgress.Size = new System.Drawing.Size(200, 20);
            // 
            // chkLinefeed
            // 
            this.chkLinefeed.AutoSize = true;
            this.chkLinefeed.Checked = true;
            this.chkLinefeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLinefeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLinefeed.ForeColor = System.Drawing.Color.Black;
            this.chkLinefeed.Location = new System.Drawing.Point(46, 50);
            this.chkLinefeed.Name = "chkLinefeed";
            this.chkLinefeed.Size = new System.Drawing.Size(149, 29);
            this.chkLinefeed.TabIndex = 22;
            this.chkLinefeed.Text = "\\n for newline";
            this.chkLinefeed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 745);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPastePublicKey);
            this.Controls.Add(this.btnCopyPublicKey);
            this.Controls.Add(this.btnPastePrivateKey);
            this.Controls.Add(this.btnCopyPrivateKey);
            this.Controls.Add(this.btnImportPublicKey);
            this.Controls.Add(this.btnImportPrivateKey);
            this.Controls.Add(this.btnExportPublic);
            this.Controls.Add(this.btnExportPrivate);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEncryptFile);
            this.Controls.Add(this.cmbKeySize);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.txtPrivateKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RSA Key Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbKeySize;
        private System.Windows.Forms.RichTextBox txtPrivateKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnExportPrivate;
        private System.Windows.Forms.Button btnExportPublic;
        private System.Windows.Forms.Button btnImportPrivateKey;
        private System.Windows.Forms.Button btnImportPublicKey;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.CheckBox chkOAEPPedding;
        private System.Windows.Forms.CheckBox chkOverflow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
       
        private System.Windows.Forms.Button btnCopyPrivateKey;
        private System.Windows.Forms.Button btnPastePrivateKey;
        private System.Windows.Forms.Button btnPasteHash;
        private System.Windows.Forms.Button btnCopyHash;
        private System.Windows.Forms.Button btnPasteText;
        private System.Windows.Forms.Button btnCopyText;
        private System.Windows.Forms.Button btnPastePublicKey;
        private System.Windows.Forms.Button btnCopyPublicKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripProgressBar pgProgress;
        private System.Windows.Forms.CheckBox chkLinefeed;
    }
}


namespace Stream_Cipher
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Encrypt = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSizeTB = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.fileNameTB = new MaterialSkin.Controls.MaterialLabel();
            this.startEncryptionBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveEncryptionBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.uploadFileBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cryptoTextPreview = new System.Windows.Forms.RichTextBox();
            this.cryptoKeyPreview = new System.Windows.Forms.RichTextBox();
            this.Decrypt = new System.Windows.Forms.TabPage();
            this.decryptionProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.decryptionResultLbl = new System.Windows.Forms.Label();
            this.decryptionPreviewText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptKeyFileLabel = new MaterialSkin.Controls.MaterialLabel();
            this.uploadKeyBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.decryptFileUploadLabel = new MaterialSkin.Controls.MaterialLabel();
            this.startDecryptionBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveDecryptedFileBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.uploadEncryptedFileBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Preview = new System.Windows.Forms.TabPage();
            this.tooltip01 = new System.Windows.Forms.Label();
            this.prvDecryptedText = new System.Windows.Forms.RichTextBox();
            this.decryptionLbl = new MaterialSkin.Controls.MaterialLabel();
            this.decryptionIcon = new System.Windows.Forms.Label();
            this.encryptionLbl = new MaterialSkin.Controls.MaterialLabel();
            this.encryptionIcon = new System.Windows.Forms.Label();
            this.previewBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.wordEncryptLbl = new MaterialSkin.Controls.MaterialLabel();
            this.wordEncrypt = new System.Windows.Forms.RichTextBox();
            this.prvDecryptedTextLbl = new MaterialSkin.Controls.MaterialLabel();
            this.prvDecryptedTextOp = new MaterialSkin.Controls.MaterialLabel();
            this.prvRandomKey2Op = new MaterialSkin.Controls.MaterialLabel();
            this.prvRandomKey2Lbl = new MaterialSkin.Controls.MaterialLabel();
            this.prvRandomKey2 = new System.Windows.Forms.RichTextBox();
            this.prvCryptoText2Lbl = new MaterialSkin.Controls.MaterialLabel();
            this.prvCryptoText2 = new System.Windows.Forms.RichTextBox();
            this.prvCryptoTextLbl = new MaterialSkin.Controls.MaterialLabel();
            this.prvCryptoTextOp = new MaterialSkin.Controls.MaterialLabel();
            this.prvRandomKeyOp = new MaterialSkin.Controls.MaterialLabel();
            this.prvRandomKeyLbl = new MaterialSkin.Controls.MaterialLabel();
            this.prvTextBinaryLbl = new MaterialSkin.Controls.MaterialLabel();
            this.prvCryptoText = new System.Windows.Forms.RichTextBox();
            this.prvRandomKey = new System.Windows.Forms.RichTextBox();
            this.prvTextBinary = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbCoreUtil = new System.Windows.Forms.ComboBox();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.chkLightTheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkMultiThreading = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.Encrypt.SuspendLayout();
            this.Decrypt.SuspendLayout();
            this.Preview.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Encrypt);
            this.materialTabControl1.Controls.Add(this.Decrypt);
            this.materialTabControl1.Controls.Add(this.Preview);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 68);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(964, 435);
            this.materialTabControl1.TabIndex = 17;
            // 
            // Encrypt
            // 
            this.Encrypt.AccessibleDescription = "test";
            this.Encrypt.AccessibleName = "test";
            this.Encrypt.BackColor = System.Drawing.Color.Gainsboro;
            this.Encrypt.Controls.Add(this.label2);
            this.Encrypt.Controls.Add(this.label1);
            this.Encrypt.Controls.Add(this.fileSizeTB);
            this.Encrypt.Controls.Add(this.materialLabel7);
            this.Encrypt.Controls.Add(this.materialLabel2);
            this.Encrypt.Controls.Add(this.fileNameTB);
            this.Encrypt.Controls.Add(this.startEncryptionBtn);
            this.Encrypt.Controls.Add(this.saveEncryptionBtn);
            this.Encrypt.Controls.Add(this.uploadFileBtn);
            this.Encrypt.Controls.Add(this.cryptoTextPreview);
            this.Encrypt.Controls.Add(this.cryptoKeyPreview);
            this.Encrypt.Location = new System.Drawing.Point(4, 22);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Padding = new System.Windows.Forms.Padding(3);
            this.Encrypt.Size = new System.Drawing.Size(956, 409);
            this.Encrypt.TabIndex = 0;
            this.Encrypt.Text = "Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 39);
            this.label2.TabIndex = 35;
            this.label2.Text = "🔒";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "🔑";
            // 
            // fileSizeTB
            // 
            this.fileSizeTB.AutoSize = true;
            this.fileSizeTB.BackColor = System.Drawing.Color.Transparent;
            this.fileSizeTB.Depth = 0;
            this.fileSizeTB.Font = new System.Drawing.Font("Roboto", 11F);
            this.fileSizeTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileSizeTB.Location = new System.Drawing.Point(96, 163);
            this.fileSizeTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileSizeTB.Name = "fileSizeTB";
            this.fileSizeTB.Size = new System.Drawing.Size(45, 19);
            this.fileSizeTB.TabIndex = 33;
            this.fileSizeTB.Text = "None";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(49, 163);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(41, 19);
            this.materialLabel7.TabIndex = 32;
            this.materialLabel7.Text = "Size:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(49, 120);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(37, 19);
            this.materialLabel2.TabIndex = 29;
            this.materialLabel2.Text = "File:";
            // 
            // fileNameTB
            // 
            this.fileNameTB.AutoSize = true;
            this.fileNameTB.BackColor = System.Drawing.Color.Transparent;
            this.fileNameTB.Depth = 0;
            this.fileNameTB.Font = new System.Drawing.Font("Roboto", 11F);
            this.fileNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileNameTB.Location = new System.Drawing.Point(96, 120);
            this.fileNameTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileNameTB.Name = "fileNameTB";
            this.fileNameTB.Size = new System.Drawing.Size(45, 19);
            this.fileNameTB.TabIndex = 28;
            this.fileNameTB.Text = "None";
            // 
            // startEncryptionBtn
            // 
            this.startEncryptionBtn.AutoSize = true;
            this.startEncryptionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startEncryptionBtn.Depth = 0;
            this.startEncryptionBtn.Icon = null;
            this.startEncryptionBtn.Location = new System.Drawing.Point(48, 234);
            this.startEncryptionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startEncryptionBtn.Name = "startEncryptionBtn";
            this.startEncryptionBtn.Primary = true;
            this.startEncryptionBtn.Size = new System.Drawing.Size(151, 36);
            this.startEncryptionBtn.TabIndex = 27;
            this.startEncryptionBtn.Text = "Start Encryption";
            this.startEncryptionBtn.UseVisualStyleBackColor = true;
            this.startEncryptionBtn.Click += new System.EventHandler(this.startEncryptionBtn_Click);
            // 
            // saveEncryptionBtn
            // 
            this.saveEncryptionBtn.AutoSize = true;
            this.saveEncryptionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveEncryptionBtn.Depth = 0;
            this.saveEncryptionBtn.Icon = null;
            this.saveEncryptionBtn.Location = new System.Drawing.Point(48, 299);
            this.saveEncryptionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveEncryptionBtn.Name = "saveEncryptionBtn";
            this.saveEncryptionBtn.Primary = true;
            this.saveEncryptionBtn.Size = new System.Drawing.Size(142, 36);
            this.saveEncryptionBtn.TabIndex = 26;
            this.saveEncryptionBtn.Text = "Save Encryption  ";
            this.saveEncryptionBtn.UseVisualStyleBackColor = true;
            this.saveEncryptionBtn.Click += new System.EventHandler(this.saveEncryptionBtn_Click);
            // 
            // uploadFileBtn
            // 
            this.uploadFileBtn.AutoSize = true;
            this.uploadFileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uploadFileBtn.Depth = 0;
            this.uploadFileBtn.Icon = null;
            this.uploadFileBtn.Location = new System.Drawing.Point(48, 49);
            this.uploadFileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.uploadFileBtn.Name = "uploadFileBtn";
            this.uploadFileBtn.Primary = true;
            this.uploadFileBtn.Size = new System.Drawing.Size(104, 36);
            this.uploadFileBtn.TabIndex = 25;
            this.uploadFileBtn.Text = "Upload File";
            this.uploadFileBtn.UseVisualStyleBackColor = true;
            this.uploadFileBtn.Click += new System.EventHandler(this.uploadFileBtn_Click);
            // 
            // cryptoTextPreview
            // 
            this.cryptoTextPreview.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cryptoTextPreview.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptoTextPreview.ForeColor = System.Drawing.SystemColors.Window;
            this.cryptoTextPreview.Location = new System.Drawing.Point(352, 38);
            this.cryptoTextPreview.Name = "cryptoTextPreview";
            this.cryptoTextPreview.ReadOnly = true;
            this.cryptoTextPreview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.cryptoTextPreview.Size = new System.Drawing.Size(569, 164);
            this.cryptoTextPreview.TabIndex = 23;
            this.cryptoTextPreview.TabStop = false;
            this.cryptoTextPreview.Text = "";
            // 
            // cryptoKeyPreview
            // 
            this.cryptoKeyPreview.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cryptoKeyPreview.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptoKeyPreview.ForeColor = System.Drawing.SystemColors.Window;
            this.cryptoKeyPreview.Location = new System.Drawing.Point(352, 239);
            this.cryptoKeyPreview.Name = "cryptoKeyPreview";
            this.cryptoKeyPreview.ReadOnly = true;
            this.cryptoKeyPreview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.cryptoKeyPreview.Size = new System.Drawing.Size(569, 164);
            this.cryptoKeyPreview.TabIndex = 24;
            this.cryptoKeyPreview.TabStop = false;
            this.cryptoKeyPreview.Text = "";
            // 
            // Decrypt
            // 
            this.Decrypt.Controls.Add(this.decryptionProgressBar);
            this.Decrypt.Controls.Add(this.decryptionResultLbl);
            this.Decrypt.Controls.Add(this.decryptionPreviewText);
            this.Decrypt.Controls.Add(this.label4);
            this.Decrypt.Controls.Add(this.label3);
            this.Decrypt.Controls.Add(this.decryptKeyFileLabel);
            this.Decrypt.Controls.Add(this.uploadKeyBtn);
            this.Decrypt.Controls.Add(this.decryptFileUploadLabel);
            this.Decrypt.Controls.Add(this.startDecryptionBtn);
            this.Decrypt.Controls.Add(this.saveDecryptedFileBtn);
            this.Decrypt.Controls.Add(this.uploadEncryptedFileBtn);
            this.Decrypt.Location = new System.Drawing.Point(4, 22);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Padding = new System.Windows.Forms.Padding(3);
            this.Decrypt.Size = new System.Drawing.Size(956, 409);
            this.Decrypt.TabIndex = 1;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            // 
            // decryptionProgressBar
            // 
            this.decryptionProgressBar.Depth = 0;
            this.decryptionProgressBar.Location = new System.Drawing.Point(132, 276);
            this.decryptionProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.decryptionProgressBar.Name = "decryptionProgressBar";
            this.decryptionProgressBar.Size = new System.Drawing.Size(154, 5);
            this.decryptionProgressBar.TabIndex = 40;
            this.decryptionProgressBar.Visible = false;
            // 
            // decryptionResultLbl
            // 
            this.decryptionResultLbl.AutoSize = true;
            this.decryptionResultLbl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptionResultLbl.ForeColor = System.Drawing.Color.Teal;
            this.decryptionResultLbl.Location = new System.Drawing.Point(106, 302);
            this.decryptionResultLbl.Name = "decryptionResultLbl";
            this.decryptionResultLbl.Size = new System.Drawing.Size(0, 21);
            this.decryptionResultLbl.TabIndex = 39;
            // 
            // decryptionPreviewText
            // 
            this.decryptionPreviewText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.decryptionPreviewText.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptionPreviewText.ForeColor = System.Drawing.SystemColors.Window;
            this.decryptionPreviewText.Location = new System.Drawing.Point(435, 41);
            this.decryptionPreviewText.Name = "decryptionPreviewText";
            this.decryptionPreviewText.ReadOnly = true;
            this.decryptionPreviewText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.decryptionPreviewText.Size = new System.Drawing.Size(498, 361);
            this.decryptionPreviewText.TabIndex = 38;
            this.decryptionPreviewText.TabStop = false;
            this.decryptionPreviewText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "🔑";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "🔒";
            // 
            // decryptKeyFileLabel
            // 
            this.decryptKeyFileLabel.AutoSize = true;
            this.decryptKeyFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.decryptKeyFileLabel.Depth = 0;
            this.decryptKeyFileLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.decryptKeyFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.decryptKeyFileLabel.Location = new System.Drawing.Point(102, 205);
            this.decryptKeyFileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.decryptKeyFileLabel.Name = "decryptKeyFileLabel";
            this.decryptKeyFileLabel.Size = new System.Drawing.Size(0, 19);
            this.decryptKeyFileLabel.TabIndex = 30;
            // 
            // uploadKeyBtn
            // 
            this.uploadKeyBtn.AutoSize = true;
            this.uploadKeyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uploadKeyBtn.Depth = 0;
            this.uploadKeyBtn.Icon = null;
            this.uploadKeyBtn.Location = new System.Drawing.Point(102, 154);
            this.uploadKeyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.uploadKeyBtn.Name = "uploadKeyBtn";
            this.uploadKeyBtn.Primary = true;
            this.uploadKeyBtn.Size = new System.Drawing.Size(154, 36);
            this.uploadKeyBtn.TabIndex = 29;
            this.uploadKeyBtn.Text = "Upload CryptoKey";
            this.uploadKeyBtn.UseVisualStyleBackColor = true;
            this.uploadKeyBtn.Click += new System.EventHandler(this.uploadKeyBtn_Click);
            // 
            // decryptFileUploadLabel
            // 
            this.decryptFileUploadLabel.AutoSize = true;
            this.decryptFileUploadLabel.BackColor = System.Drawing.Color.Transparent;
            this.decryptFileUploadLabel.Depth = 0;
            this.decryptFileUploadLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.decryptFileUploadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.decryptFileUploadLabel.Location = new System.Drawing.Point(102, 110);
            this.decryptFileUploadLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.decryptFileUploadLabel.Name = "decryptFileUploadLabel";
            this.decryptFileUploadLabel.Size = new System.Drawing.Size(0, 19);
            this.decryptFileUploadLabel.TabIndex = 27;
            // 
            // startDecryptionBtn
            // 
            this.startDecryptionBtn.AutoSize = true;
            this.startDecryptionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startDecryptionBtn.Depth = 0;
            this.startDecryptionBtn.Icon = null;
            this.startDecryptionBtn.Location = new System.Drawing.Point(36, 350);
            this.startDecryptionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startDecryptionBtn.Name = "startDecryptionBtn";
            this.startDecryptionBtn.Primary = true;
            this.startDecryptionBtn.Size = new System.Drawing.Size(150, 36);
            this.startDecryptionBtn.TabIndex = 26;
            this.startDecryptionBtn.Text = "Start Decryption";
            this.startDecryptionBtn.UseVisualStyleBackColor = true;
            this.startDecryptionBtn.Click += new System.EventHandler(this.startDecryptionBtn_Click);
            // 
            // saveDecryptedFileBtn
            // 
            this.saveDecryptedFileBtn.AutoSize = true;
            this.saveDecryptedFileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveDecryptedFileBtn.Depth = 0;
            this.saveDecryptedFileBtn.Icon = null;
            this.saveDecryptedFileBtn.Location = new System.Drawing.Point(223, 350);
            this.saveDecryptedFileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveDecryptedFileBtn.Name = "saveDecryptedFileBtn";
            this.saveDecryptedFileBtn.Primary = true;
            this.saveDecryptedFileBtn.Size = new System.Drawing.Size(165, 36);
            this.saveDecryptedFileBtn.TabIndex = 25;
            this.saveDecryptedFileBtn.Text = "Save Decrypted File";
            this.saveDecryptedFileBtn.UseVisualStyleBackColor = true;
            this.saveDecryptedFileBtn.Click += new System.EventHandler(this.saveDecryptedFileBtn_Click);
            // 
            // uploadEncryptedFileBtn
            // 
            this.uploadEncryptedFileBtn.AutoSize = true;
            this.uploadEncryptedFileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uploadEncryptedFileBtn.Depth = 0;
            this.uploadEncryptedFileBtn.Icon = null;
            this.uploadEncryptedFileBtn.Location = new System.Drawing.Point(102, 58);
            this.uploadEncryptedFileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.uploadEncryptedFileBtn.Name = "uploadEncryptedFileBtn";
            this.uploadEncryptedFileBtn.Primary = true;
            this.uploadEncryptedFileBtn.Size = new System.Drawing.Size(184, 36);
            this.uploadEncryptedFileBtn.TabIndex = 24;
            this.uploadEncryptedFileBtn.Text = "Upload Encrypted File";
            this.uploadEncryptedFileBtn.UseVisualStyleBackColor = true;
            this.uploadEncryptedFileBtn.Click += new System.EventHandler(this.uploadEncryptedFileBtn_Click);
            // 
            // Preview
            // 
            this.Preview.Controls.Add(this.tooltip01);
            this.Preview.Controls.Add(this.prvDecryptedText);
            this.Preview.Controls.Add(this.decryptionLbl);
            this.Preview.Controls.Add(this.decryptionIcon);
            this.Preview.Controls.Add(this.encryptionLbl);
            this.Preview.Controls.Add(this.encryptionIcon);
            this.Preview.Controls.Add(this.previewBtn);
            this.Preview.Controls.Add(this.wordEncryptLbl);
            this.Preview.Controls.Add(this.wordEncrypt);
            this.Preview.Controls.Add(this.prvDecryptedTextLbl);
            this.Preview.Controls.Add(this.prvDecryptedTextOp);
            this.Preview.Controls.Add(this.prvRandomKey2Op);
            this.Preview.Controls.Add(this.prvRandomKey2Lbl);
            this.Preview.Controls.Add(this.prvRandomKey2);
            this.Preview.Controls.Add(this.prvCryptoText2Lbl);
            this.Preview.Controls.Add(this.prvCryptoText2);
            this.Preview.Controls.Add(this.prvCryptoTextLbl);
            this.Preview.Controls.Add(this.prvCryptoTextOp);
            this.Preview.Controls.Add(this.prvRandomKeyOp);
            this.Preview.Controls.Add(this.prvRandomKeyLbl);
            this.Preview.Controls.Add(this.prvTextBinaryLbl);
            this.Preview.Controls.Add(this.prvCryptoText);
            this.Preview.Controls.Add(this.prvRandomKey);
            this.Preview.Controls.Add(this.prvTextBinary);
            this.Preview.Location = new System.Drawing.Point(4, 22);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(956, 409);
            this.Preview.TabIndex = 2;
            this.Preview.Text = "Algorithm Preview";
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // tooltip01
            // 
            this.tooltip01.AutoSize = true;
            this.tooltip01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tooltip01.Location = new System.Drawing.Point(470, 43);
            this.tooltip01.Name = "tooltip01";
            this.tooltip01.Size = new System.Drawing.Size(126, 13);
            this.tooltip01.TabIndex = 41;
            this.tooltip01.Text = "Message Size = Key Size";
            this.tooltip01.Visible = false;
            // 
            // prvDecryptedText
            // 
            this.prvDecryptedText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.prvDecryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prvDecryptedText.ForeColor = System.Drawing.Color.White;
            this.prvDecryptedText.Location = new System.Drawing.Point(700, 285);
            this.prvDecryptedText.Multiline = false;
            this.prvDecryptedText.Name = "prvDecryptedText";
            this.prvDecryptedText.ReadOnly = true;
            this.prvDecryptedText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.prvDecryptedText.Size = new System.Drawing.Size(172, 33);
            this.prvDecryptedText.TabIndex = 40;
            this.prvDecryptedText.TabStop = false;
            this.prvDecryptedText.Text = "         password";
            this.prvDecryptedText.Visible = false;
            // 
            // decryptionLbl
            // 
            this.decryptionLbl.AutoSize = true;
            this.decryptionLbl.Depth = 0;
            this.decryptionLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.decryptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.decryptionLbl.Location = new System.Drawing.Point(28, 309);
            this.decryptionLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.decryptionLbl.Name = "decryptionLbl";
            this.decryptionLbl.Size = new System.Drawing.Size(81, 19);
            this.decryptionLbl.TabIndex = 39;
            this.decryptionLbl.Text = "Decryption";
            this.decryptionLbl.Visible = false;
            // 
            // decryptionIcon
            // 
            this.decryptionIcon.AutoSize = true;
            this.decryptionIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptionIcon.ForeColor = System.Drawing.Color.White;
            this.decryptionIcon.Location = new System.Drawing.Point(43, 266);
            this.decryptionIcon.Name = "decryptionIcon";
            this.decryptionIcon.Size = new System.Drawing.Size(50, 39);
            this.decryptionIcon.TabIndex = 38;
            this.decryptionIcon.Text = "🔓";
            this.decryptionIcon.Visible = false;
            // 
            // encryptionLbl
            // 
            this.encryptionLbl.AutoSize = true;
            this.encryptionLbl.Depth = 0;
            this.encryptionLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.encryptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.encryptionLbl.Location = new System.Drawing.Point(28, 122);
            this.encryptionLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.encryptionLbl.Name = "encryptionLbl";
            this.encryptionLbl.Size = new System.Drawing.Size(80, 19);
            this.encryptionLbl.TabIndex = 37;
            this.encryptionLbl.Text = "Encryption";
            this.encryptionLbl.Visible = false;
            // 
            // encryptionIcon
            // 
            this.encryptionIcon.AutoSize = true;
            this.encryptionIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionIcon.ForeColor = System.Drawing.Color.White;
            this.encryptionIcon.Location = new System.Drawing.Point(43, 79);
            this.encryptionIcon.Name = "encryptionIcon";
            this.encryptionIcon.Size = new System.Drawing.Size(50, 39);
            this.encryptionIcon.TabIndex = 36;
            this.encryptionIcon.Text = "🔒";
            this.encryptionIcon.Visible = false;
            // 
            // previewBtn
            // 
            this.previewBtn.AutoSize = true;
            this.previewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previewBtn.Depth = 0;
            this.previewBtn.Icon = null;
            this.previewBtn.Location = new System.Drawing.Point(396, 241);
            this.previewBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Primary = true;
            this.previewBtn.Size = new System.Drawing.Size(125, 36);
            this.previewBtn.TabIndex = 20;
            this.previewBtn.Text = "Start Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // wordEncryptLbl
            // 
            this.wordEncryptLbl.AutoSize = true;
            this.wordEncryptLbl.Depth = 0;
            this.wordEncryptLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.wordEncryptLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wordEncryptLbl.Location = new System.Drawing.Point(392, 141);
            this.wordEncryptLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.wordEncryptLbl.Name = "wordEncryptLbl";
            this.wordEncryptLbl.Size = new System.Drawing.Size(146, 19);
            this.wordEncryptLbl.TabIndex = 19;
            this.wordEncryptLbl.Text = "Message To Encrypt";
            // 
            // wordEncrypt
            // 
            this.wordEncrypt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.wordEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordEncrypt.ForeColor = System.Drawing.Color.White;
            this.wordEncrypt.Location = new System.Drawing.Point(377, 182);
            this.wordEncrypt.Multiline = false;
            this.wordEncrypt.Name = "wordEncrypt";
            this.wordEncrypt.ReadOnly = true;
            this.wordEncrypt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.wordEncrypt.Size = new System.Drawing.Size(172, 33);
            this.wordEncrypt.TabIndex = 18;
            this.wordEncrypt.TabStop = false;
            this.wordEncrypt.Text = "         password";
            // 
            // prvDecryptedTextLbl
            // 
            this.prvDecryptedTextLbl.AutoSize = true;
            this.prvDecryptedTextLbl.Depth = 0;
            this.prvDecryptedTextLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvDecryptedTextLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvDecryptedTextLbl.Location = new System.Drawing.Point(718, 357);
            this.prvDecryptedTextLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvDecryptedTextLbl.Name = "prvDecryptedTextLbl";
            this.prvDecryptedTextLbl.Size = new System.Drawing.Size(141, 19);
            this.prvDecryptedTextLbl.TabIndex = 17;
            this.prvDecryptedTextLbl.Text = "Decrypted Message";
            this.prvDecryptedTextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prvDecryptedTextLbl.Visible = false;
            // 
            // prvDecryptedTextOp
            // 
            this.prvDecryptedTextOp.AutoSize = true;
            this.prvDecryptedTextOp.Depth = 0;
            this.prvDecryptedTextOp.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvDecryptedTextOp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvDecryptedTextOp.Location = new System.Drawing.Point(652, 292);
            this.prvDecryptedTextOp.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvDecryptedTextOp.Name = "prvDecryptedTextOp";
            this.prvDecryptedTextOp.Size = new System.Drawing.Size(17, 19);
            this.prvDecryptedTextOp.TabIndex = 16;
            this.prvDecryptedTextOp.Text = "=";
            this.prvDecryptedTextOp.Visible = false;
            // 
            // prvRandomKey2Op
            // 
            this.prvRandomKey2Op.AutoSize = true;
            this.prvRandomKey2Op.Depth = 0;
            this.prvRandomKey2Op.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvRandomKey2Op.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvRandomKey2Op.Location = new System.Drawing.Point(372, 292);
            this.prvRandomKey2Op.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvRandomKey2Op.Name = "prvRandomKey2Op";
            this.prvRandomKey2Op.Size = new System.Drawing.Size(37, 19);
            this.prvRandomKey2Op.TabIndex = 14;
            this.prvRandomKey2Op.Text = "XOR";
            this.prvRandomKey2Op.Visible = false;
            // 
            // prvRandomKey2Lbl
            // 
            this.prvRandomKey2Lbl.AutoSize = true;
            this.prvRandomKey2Lbl.Depth = 0;
            this.prvRandomKey2Lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvRandomKey2Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvRandomKey2Lbl.Location = new System.Drawing.Point(466, 357);
            this.prvRandomKey2Lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvRandomKey2Lbl.Name = "prvRandomKey2Lbl";
            this.prvRandomKey2Lbl.Size = new System.Drawing.Size(115, 19);
            this.prvRandomKey2Lbl.TabIndex = 13;
            this.prvRandomKey2Lbl.Text = "Used CryptoKey";
            this.prvRandomKey2Lbl.Visible = false;
            // 
            // prvRandomKey2
            // 
            this.prvRandomKey2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.prvRandomKey2.ForeColor = System.Drawing.Color.White;
            this.prvRandomKey2.Location = new System.Drawing.Point(426, 269);
            this.prvRandomKey2.Name = "prvRandomKey2";
            this.prvRandomKey2.ReadOnly = true;
            this.prvRandomKey2.Size = new System.Drawing.Size(210, 69);
            this.prvRandomKey2.TabIndex = 12;
            this.prvRandomKey2.Text = "";
            this.prvRandomKey2.Visible = false;
            // 
            // prvCryptoText2Lbl
            // 
            this.prvCryptoText2Lbl.AutoSize = true;
            this.prvCryptoText2Lbl.Depth = 0;
            this.prvCryptoText2Lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvCryptoText2Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvCryptoText2Lbl.Location = new System.Drawing.Point(202, 357);
            this.prvCryptoText2Lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvCryptoText2Lbl.Name = "prvCryptoText2Lbl";
            this.prvCryptoText2Lbl.Size = new System.Drawing.Size(82, 19);
            this.prvCryptoText2Lbl.TabIndex = 11;
            this.prvCryptoText2Lbl.Text = "CryptoText";
            this.prvCryptoText2Lbl.Visible = false;
            // 
            // prvCryptoText2
            // 
            this.prvCryptoText2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.prvCryptoText2.ForeColor = System.Drawing.Color.White;
            this.prvCryptoText2.Location = new System.Drawing.Point(143, 269);
            this.prvCryptoText2.Name = "prvCryptoText2";
            this.prvCryptoText2.ReadOnly = true;
            this.prvCryptoText2.Size = new System.Drawing.Size(210, 69);
            this.prvCryptoText2.TabIndex = 10;
            this.prvCryptoText2.Text = "";
            this.prvCryptoText2.Visible = false;
            // 
            // prvCryptoTextLbl
            // 
            this.prvCryptoTextLbl.AutoSize = true;
            this.prvCryptoTextLbl.Depth = 0;
            this.prvCryptoTextLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvCryptoTextLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvCryptoTextLbl.Location = new System.Drawing.Point(753, 161);
            this.prvCryptoTextLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvCryptoTextLbl.Name = "prvCryptoTextLbl";
            this.prvCryptoTextLbl.Size = new System.Drawing.Size(82, 19);
            this.prvCryptoTextLbl.TabIndex = 9;
            this.prvCryptoTextLbl.Text = "CryptoText";
            this.prvCryptoTextLbl.Visible = false;
            // 
            // prvCryptoTextOp
            // 
            this.prvCryptoTextOp.AutoSize = true;
            this.prvCryptoTextOp.Depth = 0;
            this.prvCryptoTextOp.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvCryptoTextOp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvCryptoTextOp.Location = new System.Drawing.Point(652, 100);
            this.prvCryptoTextOp.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvCryptoTextOp.Name = "prvCryptoTextOp";
            this.prvCryptoTextOp.Size = new System.Drawing.Size(17, 19);
            this.prvCryptoTextOp.TabIndex = 8;
            this.prvCryptoTextOp.Text = "=";
            this.prvCryptoTextOp.Visible = false;
            // 
            // prvRandomKeyOp
            // 
            this.prvRandomKeyOp.AutoSize = true;
            this.prvRandomKeyOp.Depth = 0;
            this.prvRandomKeyOp.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvRandomKeyOp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvRandomKeyOp.Location = new System.Drawing.Point(372, 100);
            this.prvRandomKeyOp.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvRandomKeyOp.Name = "prvRandomKeyOp";
            this.prvRandomKeyOp.Size = new System.Drawing.Size(37, 19);
            this.prvRandomKeyOp.TabIndex = 7;
            this.prvRandomKeyOp.Text = "XOR";
            this.prvRandomKeyOp.Visible = false;
            // 
            // prvRandomKeyLbl
            // 
            this.prvRandomKeyLbl.AutoSize = true;
            this.prvRandomKeyLbl.Depth = 0;
            this.prvRandomKeyLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvRandomKeyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvRandomKeyLbl.Location = new System.Drawing.Point(467, 161);
            this.prvRandomKeyLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvRandomKeyLbl.Name = "prvRandomKeyLbl";
            this.prvRandomKeyLbl.Size = new System.Drawing.Size(136, 19);
            this.prvRandomKeyLbl.TabIndex = 6;
            this.prvRandomKeyLbl.Text = "Random CryptoKey";
            this.prvRandomKeyLbl.Visible = false;
            // 
            // prvTextBinaryLbl
            // 
            this.prvTextBinaryLbl.AutoSize = true;
            this.prvTextBinaryLbl.Depth = 0;
            this.prvTextBinaryLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.prvTextBinaryLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prvTextBinaryLbl.Location = new System.Drawing.Point(176, 161);
            this.prvTextBinaryLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.prvTextBinaryLbl.Name = "prvTextBinaryLbl";
            this.prvTextBinaryLbl.Size = new System.Drawing.Size(131, 19);
            this.prvTextBinaryLbl.TabIndex = 5;
            this.prvTextBinaryLbl.Text = "Message in Binary";
            this.prvTextBinaryLbl.Visible = false;
            // 
            // prvCryptoText
            // 
            this.prvCryptoText.BackColor = System.Drawing.Color.DarkSlateGray;
            this.prvCryptoText.ForeColor = System.Drawing.Color.White;
            this.prvCryptoText.Location = new System.Drawing.Point(682, 77);
            this.prvCryptoText.Name = "prvCryptoText";
            this.prvCryptoText.ReadOnly = true;
            this.prvCryptoText.Size = new System.Drawing.Size(210, 69);
            this.prvCryptoText.TabIndex = 4;
            this.prvCryptoText.Text = "";
            this.prvCryptoText.Visible = false;
            // 
            // prvRandomKey
            // 
            this.prvRandomKey.BackColor = System.Drawing.Color.DarkSlateGray;
            this.prvRandomKey.ForeColor = System.Drawing.Color.White;
            this.prvRandomKey.Location = new System.Drawing.Point(426, 77);
            this.prvRandomKey.Name = "prvRandomKey";
            this.prvRandomKey.ReadOnly = true;
            this.prvRandomKey.Size = new System.Drawing.Size(210, 69);
            this.prvRandomKey.TabIndex = 3;
            this.prvRandomKey.Text = "";
            this.prvRandomKey.Visible = false;
            // 
            // prvTextBinary
            // 
            this.prvTextBinary.BackColor = System.Drawing.Color.DarkSlateGray;
            this.prvTextBinary.ForeColor = System.Drawing.Color.White;
            this.prvTextBinary.Location = new System.Drawing.Point(143, 77);
            this.prvTextBinary.Name = "prvTextBinary";
            this.prvTextBinary.ReadOnly = true;
            this.prvTextBinary.Size = new System.Drawing.Size(210, 69);
            this.prvTextBinary.TabIndex = 2;
            this.prvTextBinary.Text = "";
            this.prvTextBinary.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.cbCoreUtil);
            this.tabPage1.Controls.Add(this.materialCheckBox1);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.cbAlgorithm);
            this.tabPage1.Controls.Add(this.chkLightTheme);
            this.tabPage1.Controls.Add(this.chkMultiThreading);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(956, 409);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(364, 127);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(127, 19);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "Thread Utilization";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCoreUtil
            // 
            this.cbCoreUtil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCoreUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoreUtil.Items.AddRange(new object[] {
            "Low",
            "Medium (Recommended)",
            "High",
            "Full"});
            this.cbCoreUtil.Location = new System.Drawing.Point(365, 166);
            this.cbCoreUtil.Name = "cbCoreUtil";
            this.cbCoreUtil.Size = new System.Drawing.Size(220, 21);
            this.cbCoreUtil.TabIndex = 27;
            this.cbCoreUtil.SelectedIndexChanged += new System.EventHandler(this.cbCoreUtil_SelectedIndexChanged);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(365, 279);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(121, 30);
            this.materialCheckBox1.TabIndex = 26;
            this.materialCheckBox1.Text = "Overclock CPU";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(777, 370);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(169, 19);
            this.materialLabel6.TabIndex = 25;
            this.materialLabel6.Text = "Software Version: 1.0b1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(361, 49);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(150, 19);
            this.materialLabel5.TabIndex = 24;
            this.materialLabel5.Text = "Encryption Algorithm";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(751, 394);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(195, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Developed by Tarik Ćosović";
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgorithm.Items.AddRange(new object[] {
            "One Time Pad (Recommended)",
            "RC4 (Disabled)"});
            this.cbAlgorithm.Location = new System.Drawing.Point(362, 88);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(220, 21);
            this.cbAlgorithm.TabIndex = 23;
            // 
            // chkLightTheme
            // 
            this.chkLightTheme.AutoSize = true;
            this.chkLightTheme.Depth = 0;
            this.chkLightTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkLightTheme.Location = new System.Drawing.Point(365, 330);
            this.chkLightTheme.Margin = new System.Windows.Forms.Padding(0);
            this.chkLightTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkLightTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkLightTheme.Name = "chkLightTheme";
            this.chkLightTheme.Ripple = true;
            this.chkLightTheme.Size = new System.Drawing.Size(107, 30);
            this.chkLightTheme.TabIndex = 22;
            this.chkLightTheme.Text = "Light Theme";
            this.chkLightTheme.UseVisualStyleBackColor = true;
            this.chkLightTheme.CheckedChanged += new System.EventHandler(this.chkLightTheme_CheckedChanged);
            // 
            // chkMultiThreading
            // 
            this.chkMultiThreading.AutoSize = true;
            this.chkMultiThreading.Depth = 0;
            this.chkMultiThreading.Enabled = false;
            this.chkMultiThreading.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkMultiThreading.Location = new System.Drawing.Point(365, 228);
            this.chkMultiThreading.Margin = new System.Windows.Forms.Padding(0);
            this.chkMultiThreading.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMultiThreading.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMultiThreading.Name = "chkMultiThreading";
            this.chkMultiThreading.Ripple = true;
            this.chkMultiThreading.Size = new System.Drawing.Size(165, 30);
            this.chkMultiThreading.TabIndex = 21;
            this.chkMultiThreading.Text = "Enable Multithreading";
            this.chkMultiThreading.UseVisualStyleBackColor = true;
            this.chkMultiThreading.CheckedChanged += new System.EventHandler(this.chkMultiThreading_CheckedChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-13, 27);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(976, 49);
            this.materialTabSelector1.TabIndex = 18;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 504);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.materialTabControl1.ResumeLayout(false);
            this.Encrypt.ResumeLayout(false);
            this.Encrypt.PerformLayout();
            this.Decrypt.ResumeLayout(false);
            this.Decrypt.PerformLayout();
            this.Preview.ResumeLayout(false);
            this.Preview.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Decrypt;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage Preview;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Encrypt;
        private MaterialSkin.Controls.MaterialLabel decryptFileUploadLabel;
        private MaterialSkin.Controls.MaterialRaisedButton startDecryptionBtn;
        private MaterialSkin.Controls.MaterialRaisedButton uploadEncryptedFileBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel fileNameTB;
        private MaterialSkin.Controls.MaterialRaisedButton startEncryptionBtn;
        private MaterialSkin.Controls.MaterialRaisedButton saveEncryptionBtn;
        private MaterialSkin.Controls.MaterialRaisedButton uploadFileBtn;
        private System.Windows.Forms.RichTextBox cryptoTextPreview;
        private System.Windows.Forms.RichTextBox cryptoKeyPreview;
        private MaterialSkin.Controls.MaterialLabel decryptKeyFileLabel;
        private MaterialSkin.Controls.MaterialRaisedButton uploadKeyBtn;
        private MaterialSkin.Controls.MaterialCheckBox chkMultiThreading;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel fileSizeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.RichTextBox prvCryptoText;
        private System.Windows.Forms.RichTextBox prvRandomKey;
        private System.Windows.Forms.RichTextBox prvTextBinary;
        private MaterialSkin.Controls.MaterialLabel prvCryptoTextLbl;
        private MaterialSkin.Controls.MaterialLabel prvCryptoTextOp;
        private MaterialSkin.Controls.MaterialLabel prvRandomKeyOp;
        private MaterialSkin.Controls.MaterialLabel prvRandomKeyLbl;
        private MaterialSkin.Controls.MaterialLabel prvTextBinaryLbl;
        private MaterialSkin.Controls.MaterialLabel prvDecryptedTextLbl;
        private MaterialSkin.Controls.MaterialLabel prvDecryptedTextOp;
        private MaterialSkin.Controls.MaterialLabel prvRandomKey2Op;
        private MaterialSkin.Controls.MaterialLabel prvRandomKey2Lbl;
        private System.Windows.Forms.RichTextBox prvRandomKey2;
        private MaterialSkin.Controls.MaterialLabel prvCryptoText2Lbl;
        private System.Windows.Forms.RichTextBox prvCryptoText2;
        private MaterialSkin.Controls.MaterialLabel wordEncryptLbl;
        private System.Windows.Forms.RichTextBox wordEncrypt;
        private MaterialSkin.Controls.MaterialRaisedButton previewBtn;
        private MaterialSkin.Controls.MaterialLabel encryptionLbl;
        private System.Windows.Forms.Label encryptionIcon;
        private MaterialSkin.Controls.MaterialLabel decryptionLbl;
        private System.Windows.Forms.Label decryptionIcon;
        private System.Windows.Forms.RichTextBox prvDecryptedText;
        private System.Windows.Forms.Label tooltip01;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cbCoreUtil;
        private MaterialSkin.Controls.MaterialCheckBox chkLightTheme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox decryptionPreviewText;
        private MaterialSkin.Controls.MaterialRaisedButton saveDecryptedFileBtn;
        private System.Windows.Forms.Label decryptionResultLbl;
        private MaterialSkin.Controls.MaterialProgressBar decryptionProgressBar;
    }
}


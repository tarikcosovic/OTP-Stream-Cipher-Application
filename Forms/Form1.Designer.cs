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
            this.decryptionResultLabel = new MaterialSkin.Controls.MaterialLabel();
            this.decryptKeyFileLabel = new MaterialSkin.Controls.MaterialLabel();
            this.uploadKeyBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.decryptFileUploadLabel = new MaterialSkin.Controls.MaterialLabel();
            this.startDecryptionBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveDecryptedFileBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.uploadEncryptedFileBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Preview = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.cryptoKeyPreview.Text = "";
            // 
            // Decrypt
            // 
            this.Decrypt.Controls.Add(this.decryptionResultLabel);
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
            // decryptionResultLabel
            // 
            this.decryptionResultLabel.AutoSize = true;
            this.decryptionResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.decryptionResultLabel.Depth = 0;
            this.decryptionResultLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.decryptionResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.decryptionResultLabel.Location = new System.Drawing.Point(251, 336);
            this.decryptionResultLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.decryptionResultLabel.Name = "decryptionResultLabel";
            this.decryptionResultLabel.Size = new System.Drawing.Size(0, 19);
            this.decryptionResultLabel.TabIndex = 31;
            // 
            // decryptKeyFileLabel
            // 
            this.decryptKeyFileLabel.AutoSize = true;
            this.decryptKeyFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.decryptKeyFileLabel.Depth = 0;
            this.decryptKeyFileLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.decryptKeyFileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.decryptKeyFileLabel.Location = new System.Drawing.Point(487, 152);
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
            this.uploadKeyBtn.Location = new System.Drawing.Point(255, 144);
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
            this.decryptFileUploadLabel.Location = new System.Drawing.Point(487, 87);
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
            this.startDecryptionBtn.Location = new System.Drawing.Point(255, 253);
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
            this.saveDecryptedFileBtn.Location = new System.Drawing.Point(445, 253);
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
            this.uploadEncryptedFileBtn.Location = new System.Drawing.Point(255, 79);
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
            this.Preview.Location = new System.Drawing.Point(4, 22);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(956, 409);
            this.Preview.TabIndex = 2;
            this.Preview.Text = "Algorithm Preview";
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
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
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(375, 357);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(165, 19);
            this.materialLabel6.TabIndex = 25;
            this.materialLabel6.Text = "Software Version 1.0b1";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(361, 60);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(228, 19);
            this.materialLabel5.TabIndex = 24;
            this.materialLabel5.Text = "Encryption/Decryption Algorithm";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(361, 386);
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
            "RC4"});
            this.cbAlgorithm.Location = new System.Drawing.Point(362, 100);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(220, 21);
            this.cbAlgorithm.TabIndex = 23;
            // 
            // chkLightTheme
            // 
            this.chkLightTheme.AutoSize = true;
            this.chkLightTheme.Depth = 0;
            this.chkLightTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkLightTheme.Location = new System.Drawing.Point(362, 219);
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
            this.chkMultiThreading.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkMultiThreading.Location = new System.Drawing.Point(362, 170);
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
        private MaterialSkin.Controls.MaterialRaisedButton saveDecryptedFileBtn;
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
        private MaterialSkin.Controls.MaterialLabel decryptionResultLabel;
        private MaterialSkin.Controls.MaterialCheckBox chkMultiThreading;
        private MaterialSkin.Controls.MaterialCheckBox chkLightTheme;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel fileSizeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stream_Cipher
{
    public partial class Form1 : MaterialForm
    {
        private OpenFileDialog ofd = new OpenFileDialog();

        public string currentFilePath;
        public string currentKeyPath;
        public string decryptedResult;

        #region FormInitializers
        public Form1()
        {
            this.InitializeComponent();

            this.InitializeSettings();
            this.InitializeTheme();
            this.InitializeOpenFileDialog();
        }
        private void InitializeSettings()
        {
            chkMultiThreading.Checked = Properties.Settings.Default.isMultiThreadingEnabled;
            chkLightTheme.Checked = Properties.Settings.Default.isLightThemeEnabled;

            cbAlgorithm.SelectedIndex = 0;
        }
        private void InitializeTheme()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            if (Properties.Settings.Default.isLightThemeEnabled)
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }
        private void InitializeOpenFileDialog()
        {
            ofd.Title = "Open File To Encrypt/Decrypt";
            ofd.Filter = "Text File|*.txt"; // JPG image|*.jpg|PNG Image|*.png|
        }
        #endregion

        #region GeneralControls

        private void UploadFile(MaterialLabel fileNameLabel, ref string filePath, MaterialLabel sizeLabel = null)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var size = new FileInfo(ofd.FileName).Length.ToString() + " bytes";

                if (sizeLabel != null)
                {
                    sizeLabel.Text = size;
                    size = "";
                }

                fileNameLabel.Text = ofd.SafeFileName + " " + size + " ✔️";
                filePath = ofd.FileName;

                MessageBox.Show("File " + ofd.SafeFileName + " successfully uploaded!", "Success");
            }
        }

        private void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text File|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var encryptedFileName = sfd.FileName.Substring(0, sfd.FileName.Length - 4) + "-encrypted.txt";
                var keyFileName = sfd.FileName.Substring(0, sfd.FileName.Length - 4) + "-key.txt";

                IOHelper.TextIO.WriteText(encryptedFileName, cryptoTextPreview.Text);
                IOHelper.TextIO.WriteText(keyFileName, cryptoKeyPreview.Text);
            }
        }

        #endregion


        #region EncryptionTab

        private void uploadFileBtn_Click(object sender, EventArgs e) => this.UploadFile(fileNameTB, ref currentFilePath, fileSizeTB);
        private void saveEncryptionBtn_Click(object sender, EventArgs e) => this.SaveFile();
        private void startEncryptionBtn_Click(object sender, EventArgs e) 
        {
            if (!ValidateEncryptionForm()) return;

            EncryptFile();
        }

        private bool ValidateEncryptionForm()
        {
            if (string.IsNullOrWhiteSpace(this.currentFilePath))
            {
                MessageBox.Show("Please upload a valid file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        private void EncryptFile()
        {
            //Replace with IOHelper BinaryReader ReadBytes Method..
            //File Bytes 
            string test = IOHelper.TextIO.ReadText(this.currentFilePath);
            byte[] fileByteData = File.ReadAllBytes(this.currentFilePath);

            StreamCipherDTO result = StreamCipher.OneTimePad.Encrypt(fileByteData);

            if (result == null)
            {
                cryptoTextPreview.Text = "Could not encrypt file..";
                return;
            }

            cryptoTextPreview.Text = Convert.ToBase64String(result.cryptoText);
            cryptoKeyPreview.Text = Convert.ToBase64String(result.cryptoKey); 
        }

        #endregion

     
        #region DecryptionTab


        private void uploadEncryptedFileBtn_Click(object sender, EventArgs e) => this.UploadFile(decryptFileUploadLabel, ref currentFilePath);
        private void uploadKeyBtn_Click(object sender, EventArgs e) => this.UploadFile(decryptKeyFileLabel, ref currentKeyPath);
        private void startDecryptionBtn_Click(object sender, EventArgs e) => this.DecryptFile();
        private void saveDecryptedFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text File|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var decryptedFileName = sfd.FileName.Substring(0, sfd.FileName.Length - 4) + "-decrypted.txt";

                IOHelper.TextIO.WriteText(decryptedFileName, decryptedResult);
            }
        }

        private void DecryptFile()
        {
            //Reading cryptoText and cryptoKey from file and converting from base64 to bytes
            var message = IOHelper.TextIO.ReadText(currentFilePath);
            byte[] cryptoText = Convert.FromBase64String(message);

            var key = IOHelper.TextIO.ReadText(currentKeyPath);
            byte[] cryptoKey = Convert.FromBase64String(key);

            //Decrypting the file
            decryptedResult = StreamCipher.OneTimePad.Decrypt(cryptoText, cryptoKey);

            decryptionResultLabel.Text = "Successfully decrypted file " + Path.GetFileName(currentFilePath);
        }


        #endregion


        #region SettingsTab

        private void chkMultiThreading_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isMultiThreadingEnabled = chkMultiThreading.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkLightTheme_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isLightThemeEnabled = chkLightTheme.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion
    }
}

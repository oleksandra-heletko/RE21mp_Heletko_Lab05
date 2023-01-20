using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Heletko_Lab05
{
    public partial class Form1 : Form
    {
        byte[] iArray = new byte[0];
        byte[] oArray = new byte[0];

        public Form1()
        {
            InitializeComponent();
        }

        private byte[] MyEncoding(byte[] iArray)
        {
            byte[] result = { 0 };
            if (crcRadioButton.Checked == true)
            {
                uint a = CRC.CRC32(iArray);
                return BitConverter.GetBytes(a);
            }
            if (hashRadioButton.Checked == true)
            {
                HashAlgorithm sha = KeyedHashAlgorithm.Create();
                return sha.ComputeHash(iArray);
            }
            if (ripeRadioButton.Checked == true)
            {
                HashAlgorithm sha = RIPEMD160.Create();
                return sha.ComputeHash(iArray);
            }
            if (md5RadioButton.Checked == true)
            {
                HashAlgorithm sha = MD5.Create();
                return sha.ComputeHash(iArray);
            }
            if (sha1RadioButton.Checked == true)
            {
                HashAlgorithm sha = SHA1.Create();
                return sha.ComputeHash(iArray);
            }
            if (sha256RadioButton.Checked == true)
            {
                HashAlgorithm sha = SHA256.Create();
                return sha.ComputeHash(iArray);
            }
            if (sha384RadioButton.Checked == true)
            {
                HashAlgorithm sha = SHA384.Create();
                return sha.ComputeHash(iArray);
            }
            if (sha512RadioButton.Checked == true)
            {
                HashAlgorithm sha = SHA512.Create();
                return sha.ComputeHash(iArray);
            }
            return result;
        }

        private void iFileOpenButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            openDialog.FilterIndex = 2;
            openDialog.RestoreDirectory = true;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                iFileTextBox.Text = openDialog.FileName;
                string fPath = iFileTextBox.Text;
                if (fPath == "")
                {
                    MessageBox.Show("Неправильний шлях до файлу!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    iFileOpenButton.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                if (!File.Exists(fPath))
                {
                    MessageBox.Show("Даного файлу не існує!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    iFileOpenButton.Focus();
                    this.Cursor = Cursors.Default;
                    return;
                }
                this.iArray = File.ReadAllBytes(fPath);
                iFileSizeLabel.Text = String.Format("= {0:0.000} Мб", (double)this.iArray.Length/1048576.0);
            }
            this.Cursor = Cursors.Default;
        }

        private void oFSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.FileName = "MyKey";
            saveDialog.Filter = "Все файлы (*.*)|*.*|Текстовые файлы (*.txt)|*.txt";
            saveDialog.FilterIndex = 2;
            saveDialog.CreatePrompt = true;
            saveDialog.OverwritePrompt = true;
            saveDialog.RestoreDirectory = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                oFileTextBox.Text = saveDialog.FileName;
                string sPath = oFileTextBox.Text;

                if (sPath == "")
                {
                    MessageBox.Show("Неправильний шлях до файлу!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oFileSaveButton.Focus();
                    return;
                }
            }
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            string sum = "";
            string oPath = oFileTextBox.Text;
            DateTime sTime;
            DateTime fTime;
            TimeSpan aTime;
            totTimeLabel.Text = "0:00:00:00.00";
            if (oPath == "")
            {
                MessageBox.Show("Неправильний шлях до файлу!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oFileSaveButton.Focus();
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            sTime = DateTime.Now;
            this.oArray = MyEncoding(iArray);
            File.WriteAllBytes(oPath, this.oArray);
            oFileSizeLabel.Text = String.Format("= {0} б", this.oArray.Length);
            sum = BitConverter.ToString(oArray).Replace("-", "");
            fTime = DateTime.Now;
            aTime = fTime - sTime;
            totTimeLabel.Text = aTime.ToString(@"d\:hh\:mm\:ss\.ffffff");
            MessageBox.Show(String.Format("Контрольна сума записана у файл: {0}", sum), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Cursor = Cursors.Default;
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            iArray = new byte[0];
            oArray = new byte[0];
            iFileTextBox.Text = "";
            oFileTextBox.Text = "";
            totTimeLabel.Text = "0:00:00:00.000000";
            iFileSizeLabel.Text = "???";
            oFileSizeLabel.Text = "???";
            crcRadioButton.Checked = false;
            hashRadioButton.Checked = false;
            md5RadioButton.Checked = false;
            ripeRadioButton.Checked = false;
            sha1RadioButton.Checked = false;
            sha256RadioButton.Checked = false;
            sha384RadioButton.Checked = false;
            sha512RadioButton.Checked = false;
        }

        private void aLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Студентка\r\n Гелетко О. Я.\r\n РТФ\r\n Викладач\r\n Навроцький Д. О.", "Автор", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Генератор\r\n Цифрового підпису\r\n для файлів", "Опис програми", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

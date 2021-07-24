using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && e.KeyChar != (char)(Keys.Back))
            {
                e.Handled = true;
            }
        }

        // при decode==1, запускает ширование, при decode== -1 - расшифрование
        private void StartCoding(int decode, string fileTitle)
        {
            string textToCode;
            string resultFileName;
            var dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            var result = dialog.ShowDialog();

            if (dialog.FileName != "")
            {
                // открываем файл с текстом для (рас)шифрования
                textToCode = File.ReadAllText(dialog.FileName, Encoding.Default);

                // получаем (рас)шифрованный текст
                var cipcher = new Cipher();
                var text = cipcher.Code(textToCode, decode * Convert.ToInt32(shiftValue.Text));

                // сохраняем (рас)шифрованный текст
                resultFileName = Path.GetFileNameWithoutExtension(dialog.FileName) + fileTitle;
                File.WriteAllText(resultFileName, text, Encoding.Default);
                Process.Start("notepad.exe", resultFileName);
            }
        }

        private void CodeButton_Click(object sender, EventArgs e)
        {
            // пуск шифрования
            StartCoding(1, "-code.txt");
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            // пуск расшифрования
            StartCoding(-1, "-decode.txt");
        }

    }
}

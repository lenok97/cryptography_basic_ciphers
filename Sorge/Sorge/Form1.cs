using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SorgeCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                var cipcher = new SorgeCipher(keyWord.Text);
                string text = "";
                if (decode==1)
                    text = cipcher.Code(textToCode.ToUpper());
                else
                    text = cipcher.Decode(textToCode);

                matrix.Text = cipcher.matrix.ToString();
                
                
                
                // сохраняем (рас)шифрованный текст
                resultFileName = Path.GetFileNameWithoutExtension(dialog.FileName) + fileTitle;
                File.WriteAllText(resultFileName, text, Encoding.Default);
                Process.Start("notepad.exe", resultFileName);

            }
        }

        private void StartCode_Click(object sender, EventArgs e)
        {
            // пуск шифрования
            StartCoding(1, "-code.txt");
        }

        private void StartDecode_Click(object sender, EventArgs e)
        {
            // пуск расшифрования
            StartCoding(-1, "-decode.txt");
        }
    }
}

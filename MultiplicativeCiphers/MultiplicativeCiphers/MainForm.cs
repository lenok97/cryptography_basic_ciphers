using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MultiplicativeCiphers
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // при code==true, запускает ширование, иначе - расшифрование
        private void StartCoding(string fileTitle, bool code)
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
                var cipcher = new MultiplicativeCipher();
                var text = cipcher.Code(textToCode, code);

                // сохраняем (рас)шифрованный текст
                resultFileName = Path.GetFileNameWithoutExtension(dialog.FileName) + fileTitle;
                File.WriteAllText(resultFileName, text, Encoding.Default);
                Process.Start("notepad.exe", resultFileName);
            }
        }

        private void CodeButton_Click(object sender, EventArgs e)
        {
            // пуск шифрования
            StartCoding("-code.txt", true);
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            // пуск расшифрования
            StartCoding("-decode.txt", false);
        }

    }
}

using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            long p= Convert.ToInt64(pValue.Text);
            long q = Convert.ToInt64(qValue.Text);

            // проверяем, что выбранные p, q - простые и не равны между собой 
            if (IsTheNumberSimple(p) && IsTheNumberSimple(q) && p!=q)
            {
                var rsa = new RSAEncryption(p, q);
                encrypdetText.Text = rsa.Encrypt(inputText.Text.ToUpper());
                decrypdetText.Text = rsa.Decrypt(encrypdetText.Text.Trim(' ').Split(' ').ToList());
                eValue.Text = rsa.E.ToString();
                dValue.Text = rsa.D.ToString();
                nValue.Text = rsa.N.ToString();
            }

            else
            {
                MessageBox.Show("p или q должны быть простыми неравными числами");
                return;
            }
        }

        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        private void CheckValidSymbols(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && e.KeyChar != (char)(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void qValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidSymbols(sender, e);
        }

        private void pValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidSymbols(sender, e);
        }
    }
}

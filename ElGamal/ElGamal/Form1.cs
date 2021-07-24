using System;
using System.Windows.Forms;

namespace ElGamal
{
    public partial class Form1 : Form
    {
        int p = 593; // случайное простое число
        int e1 = 123; // целое число g — первообразный корень p
        int r = 120; // Закрытый ключ. случайное целое число: 1 < r < p-1

        public Form1()
        {
            InitializeComponent();
            pLabel.Text = "p = "+p.ToString();
            gLabel.Text = "e1 = " + e1.ToString();
            xLabel.Text = "r = " + r.ToString();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            var elgamal = new ElGamalEncryption();
            encrypdetText.Text = elgamal.Encrypt(p, e1, r, inputText.Text);
            decrypdetText.Text = elgamal.Decrypt(p, r, encrypdetText.Text);
        }
    }
}

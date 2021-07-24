using System;
using System.Collections.Generic;

namespace ElGamal
{
    class ElGamalEncryption
    {
        private int Rand()
        {
            Random random = new Random();
            return random.Next();
        }

        /// <summary>
        /// (a^b) mod n - возведение a в степень b по модулю n
        /// </summary>
        int Power(int a, int b, int n)
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                        sum -= n;
                }
                tmp = sum;
            }
            return tmp;
        }

        /// <summary>
        /// (a*b) mod n - умножение a на b по модулю n
        /// </summary>
        int Multiply(int a, int b, int n)
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                    sum -= n;
            }
            return sum;
        }

        /// <summary>
        /// Функция шифрования
        /// </summary>
        public string Encrypt(int p, int e1, int r, string inPut) //Шифрование
        {
            string outPut = "";
            int e2 = Power(e1, r, p); // y = (g ^ x) mod  p. Откытый ключ

            IEnumerator<char> Enum = inPut.GetEnumerator();
            Enum.Reset();

            if (Enum.MoveNext())
            {
                char ch = Enum.Current;
                int m = Convert.ToInt32(ch);
                for (int i = 1; i <= inPut.Length; i++)
                {
                    if (m > 0)
                    {
                        ch = Enum.Current;
                        m = Convert.ToInt32(ch);
                        // метод "возведения в квадрат и умножения"
                        int k = Rand() % (p - 2) + 1; // 1 < k < (p-1)
                        int a = Power(e1, k, p);
                        int b = Multiply(Power(e2, k, p), m, p);
                        outPut += a + " " + b + " ";
                        Enum.MoveNext();
                    }
                }
            }
            return outPut;
        }

        /// <summary>
        /// Функция дешифрования
        /// </summary>
        public string Decrypt(int p, int x, string inPut)
        {
            string outPut = "";
            string[] ciphertext = inPut.Split(' '); // разделим символы (числа)
            if (ciphertext.Length > 0)
            {
                for (int i = 0; i < ciphertext.Length - 1; i += 2)
                {
                    char ch1 = (char)(Convert.ToInt32(ciphertext[i]));
                    char ch2 = (char)(Convert.ToInt32(ciphertext[i + 1]));

                    if ((ch1 != 0) && (ch2 != 0))
                    {
                        // m=b*(a^x)^(-1)mod p =  b*a^(p-1-x)mod p 
                        int M = Multiply(ch2, Power(ch1, p - 1 - x, p), p);
                        outPut += ((char)M).ToString();
                    }
                }
                return outPut;
            }
            else
                return "";
        }
    }
}

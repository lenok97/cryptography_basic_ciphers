using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicativeCiphers
{
    class MultiplicativeCipher
    {
        List<string> alphabet;

        // rus
        //int K1 = 5;
        //int K2 = 3;
        //int K1_ = 20;

        // en
        int K1 = 7; // взаимно простой с tape.Length
        int K2 = 2; // для афинного шифра
        int K1_ = 15;
        // мультипликативная инверсия от K1, то есть (K1*K1_)  mod (tape.Length) = 1


        public MultiplicativeCipher()
        {
            alphabet = new List<string>();
            alphabet.Add("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            alphabet.Add("abcdefghijklmnopqrstuvwxyz");
            //alphabet.Add("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            //alphabet.Add("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
        }

        /// <summary>
        /// Функция кодирования текста
        /// </summary>
        /// <param name="text">кодируемый текст</param>
        /// <param name="code"> при code =true запускает шифрование, 
        /// при code = false  запускает дешифрование</param>
        /// <returns>шифрованный или дешифрованный текст</returns>
        public string Code(string text, bool code)
        {
            string codedText = "";
            foreach (var ch in text)
            {
                int pos = -1;
                foreach (var alpha in alphabet)
                {
                    pos = alpha.IndexOf(ch);
                    if (pos >= 0)
                    {
                        if (code)
                            codedText += Chipcher(alpha, pos);
                        else
                            codedText += ChipcherBack(alpha, pos);
                        break;
                    }
                }
                // если не в одной ленте нет символа, помещаем его в исходном виде
                if (pos < 0)
                    codedText += ch;
            }
            return codedText;
        }

        // Функция сдвига для шифрования
        private char Chipcher(string tape, int pos)
        {
            pos = (K1 * pos + K2) % tape.Length;
            if (pos < 0)
                pos += tape.Length;
            return tape[pos];
        }

        // Функция сдвига для расшифрования
        private char ChipcherBack(string tape, int pos)
        {
            Console.WriteLine(K1_);
            pos = ((pos - K2) * K1_) % tape.Length;
            if (pos < 0)
                pos += tape.Length;
            return tape[pos];
        }

    }
}

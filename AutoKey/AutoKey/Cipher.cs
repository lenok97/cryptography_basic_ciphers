using System;
using System.Collections.Generic;

namespace CaesarCipher
{
    class Cipher
    {
        List<string> alphabet;

        public Cipher()
        {
            alphabet = new List<string>();
            alphabet.Add("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            alphabet.Add("abcdefghijklmnopqrstuvwxyz");
            alphabet.Add("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            alphabet.Add("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            alphabet.Add("0123456789");
        }

        public string Code(string text, int shift, int back)
        {
            string codedText = "";
            int autoShift = shift;
            int pos = -1;
            foreach (var ch in text)
            {
                foreach (var alpha in alphabet)
                {
                    pos = alpha.IndexOf(ch);
                    if (pos>=0)
                    {
                        char K= Chipcher(alpha, pos, autoShift * back);
                        codedText += K;
                        if (back == 1)
                        {
                            autoShift = pos;
                        }
                        else
                            autoShift = alpha.IndexOf(K);
                        break;
                    }
                }
                // если не в одной ленте нет символа, помещаем его в исходном виде
                if (pos < 0)
                {
                    codedText += ch;
                }
            }
            return codedText;
        }

        // Функция сдвига
        private char Chipcher(string tape, int pos, int shift)
        {
            pos = (pos + shift) % tape.Length;
            if (pos < 0)
                pos += tape.Length;
            return tape[pos];
        }
    }
}

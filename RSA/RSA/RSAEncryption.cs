using System;
using System.Collections.Generic;
using System.Numerics;

namespace RSA
{
    class RSAEncryption
    {
        public BigInteger D { get; private set; }
        public BigInteger E { get; private set; }
        public BigInteger Fi { get; private set; }
        public BigInteger N { get; private set; }

        public RSAEncryption(BigInteger p, BigInteger q)
        {
            Fi = (p - 1) * (q - 1); // m - функция Эйлера
            E = SimpleMutually(Fi); // e взаимопростое с fi и от 1 до fi
            N = p * q; // (e, n) - открытый ключ
            D = ModInverse(E, Fi); // d - это инверсия e по модулю fi. Секретный ключ
        }

        char[] alpabet = new char[] { '?', '!', ',', '-', '.', ' ',
            'Q','W','E','R','T','Y','U','I','O','P','A','S','D','F','G','H','J','K','L','Z','X','C','V','B','N','M',
            'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С',
            'Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ь','Ы','Ъ','Э','Ю','Я',
            '1','2','3','4','5','6','7','8','9','0',
        };

        private BigInteger SimpleMutually(BigInteger mutuallyWith)
        {
            bool b = true;
            BigInteger number = (BigInteger)Math.Truncate((decimal)Math.Sqrt((ulong)mutuallyWith));
            while (b)
            {
                // пока наименьший общий делитель не равен 1, продолжаем
                if (BigInteger.GreatestCommonDivisor(mutuallyWith, number) != 1)
                    number--;
                else
                    b = false; 
            }
            return number;
        }

        public static BigInteger ModInverse(BigInteger number, BigInteger module)
        {
            BigInteger i = module, inverse = 0, d = 1;
            while (number > 0)
            {
                BigInteger t = i / number, x = number;
                number = i % x;
                i = x;
                x = d;
                d = inverse - t * x;
                inverse = x;
            }
            inverse %= module;
            if (inverse < 0)
                inverse = (inverse + module) % module;
            return inverse;
        }

        //зашифровать
        public string Encrypt(string input)
        {
            string result = "";
            BigInteger P;
            foreach (var ch in input)
            {
                int index = Array.IndexOf(alpabet, ch);
                P = new BigInteger(index);
                // Возводим каждый символ в степень
                P = BigInteger.Pow(P, (int)E);
                // находим остаток от деления полученного символа по модулю
                P = P % new BigInteger((int)N);
                result += P.ToString() + " ";
            }
            return result;
        }

        //расшифровать
        public string Decrypt(List<string> input)
        {
            string result = "";
            BigInteger C;
            foreach (string P in input)
            {
                C= new BigInteger(Convert.ToDouble(P));
                // Возводим каждый символ в степень
                C = BigInteger.Pow(C, (int)D);
                // находим остаток от деления полученного символа по модулю
                C = C % new BigInteger((int)N);
                result += alpabet[Convert.ToInt32(C.ToString())].ToString();
            }
            return result;
        }
    }
}

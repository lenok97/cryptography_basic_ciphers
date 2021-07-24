using System;
using System.Collections.Generic;
using System.Linq;

namespace SorgeCipher
{

    public class Indexes
    {
        public Indexes (int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X;
        public int Y;
    }

    public class WheatstoneMatrix
    {
        public char[,] matrix;
        public int X, Y;
        private int currentX=0, currentY =0;
        
        // индексатор
        public char this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }
        }

        public WheatstoneMatrix(int x, int y, string keyWord, string alphabet)
        {
            X = x;
            Y = y;
            matrix = new char[X, Y];
            foreach (char ch in keyWord.ToCharArray())
                Add(ch);
            foreach (char ch in alphabet)
                Add(ch);
        }

        private void Add(char ch)
        {
            if (IndexesOf(ch)!=null)
                return;
            matrix[currentX, currentY] = ch;
            currentY++;
            if (currentY==Y)
            {
                currentY = 0;
                currentX++;
            }
        }

        public Indexes IndexesOf(char ch)
        {
            for (int i = 0; i < X; i++)
                for (int j = 0; j < Y; j++)
                    if (matrix[i, j] == ch)
                        return new Indexes(i, j);
            return null;
        }

        public override string ToString()
        {
            string line = "";
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                    line+=matrix[i, j].ToString() + " ";
                line += "\r\n";
            }
            return line;
        }
    }

    public class SorgeCipher
    {
        public WheatstoneMatrix matrix;
        private string keyWord;
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ./- ";
        private string asintoer = "ASINTOER"; // наиболее часто встречающиеся буквы английского алфавита
        private int rowIndexShift = 7; // сдвиг нумерации столбцов
        private int lineIndexShift = 1; // сдвиг нумерации строк

        private List<int> gamma = new List<int>{ 324, 36, 380, 230, 6683, 4358, 50, 2841 }; 
        // гамма (бралась из общедоступного источника. Например из «Немецкого статистического ежегодника»)
        // выпуск, страница и строка источника шифровалась первой цифровой шифротекста (зв данной реализации опущенно)

        public SorgeCipher(string keyWord)
        {
            this.keyWord = keyWord;
        }

        /// <summary>
        /// формирует таблицы
        /// </summary>
        private void SetMatrix()
        {
            int x = 5, y = 6;
            // формируем первоначальную таблицу. 
            // Заполняем ее сначала ключевым словом. затем остальными символами алфавита
            matrix = new WheatstoneMatrix(x, y, keyWord.ToUpper(), alphabet);

            // наиболее часто встречающиеся буквы английского алфавита запоминаем в порядке появления в таблице
            string asintoerOrder = "";
            for (int i = 0; i < y; i++)
                for (int j = 0; j < x; j++)
                    if (asintoer.Contains(matrix[j, i].ToString()))
                        asintoerOrder += matrix[j, i];

            // остальные буквы в порядке появления в таблице
            string lastAlphabet = " -";
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                    lastAlphabet += matrix[j, i];
            }

            // формируем рабочую таблицу
            matrix = new WheatstoneMatrix(3, 10, asintoerOrder, lastAlphabet);
        }

        /// <summary>
        /// Кодирование текста 
        /// </summary>
        /// <returns>зашифрованный текст</returns>
        public string Code(string textToCode)
        {
            string codedText = "";
            textToCode = Normalise(textToCode);
            SetMatrix();


            foreach (char ch in textToCode)
            {
                var index = matrix.IndexesOf(ch);

                //Для каждого исходного символа ищем соответствующую ему цифру в первом столбце
                int xIndex = index.X + rowIndexShift;
                //Для каждого исходного символа ищем соответствующую ему цифру в первом ряду
                int yIndex = index.Y + lineIndexShift;
                codedText += Convert.ToString(xIndex) ;
                codedText += Convert.ToString(yIndex); // Записываем полученные символы один за другим
            }

            // завершаем последнюю группу до 5 символов
            while (codedText.Length % 5 != 0)
            {
                codedText += '0';
            }

            // шифротекстпереразбивается на блоки по 5 символов
            List<string> grouped = new List<string>();
            for (int i = 0; i < codedText.Length - 4; i += 5)
                grouped.Add(codedText.Substring(i, 5));

            // накладываем на шифротекст выбранную гамму
            var gammaed = SetGamma(grouped, 1);

            codedText = "";
            foreach (int gamma in gammaed)
            {
                codedText += gamma.ToString() + " ";
            }
            return codedText;
        }

        /// <summary>
        /// Накладывает на шифротекст гамму
        /// </summary>
        /// <param name="grouped">шифротекст представленный в виде групп по 5 цифр</param>
        /// <param name="decode">кодировать или декодировать?</param>
        /// <returns>гаммированный текст</returns>
        private List<int> SetGamma(List<string> grouped, int decode)
        {
            var gammaed = new List<int>();
            foreach (var group in grouped)
            {
                gammaed.Add(Convert.ToInt32(group));
                gammaed[gammaed.Count - 1] += ((gamma[(gammaed.Count - 1) % gamma.Count]) * decode);
            }
            Console.WriteLine(gamma.Count);
            Console.WriteLine(gammaed.Count);
            return gammaed;
        }

        public string Decode(string codedText)
        {
            string decodedText = "";
            SetMatrix();
            var text = codedText.Split(' ').ToList();
            text.Remove("");

            var grouped = SetGamma(text, -1); // снимаем гамму
            codedText = "";
            foreach (var group in grouped)
                codedText += group.ToString(); // объединяем для удобства работы

            // анализируем шифротекст согласно таблице
            for (int i=0; i<codedText.Length-1; i+=2)
            {
                int x = Convert.ToInt32(codedText[i].ToString())-rowIndexShift;
                int y = Convert.ToInt32(codedText[i+1].ToString())- lineIndexShift;
                if (x < 0 || y < 0)
                    continue; // игнорирование лишних нулей
                decodedText += matrix[x, y];
            }
            return decodedText;
        }

        private string Normalise(string line)
        {
            foreach (var ch in line)
            {
                if (!alphabet.Contains(ch.ToString()))
                    line = line.Replace(ch.ToString(), "/");
            }
            return line;
        }
    }
}

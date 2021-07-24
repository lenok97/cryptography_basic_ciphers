using System;
using System.Collections.Generic;

namespace PlayfairCipher
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
                if (x == X)
                    x = 0;
                if (y == Y)
                    y = 0;
                if (x == -1)
                    x = X-1;
                if (y == -1)
                    y = Y-1;
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


    public class Cipher
    {
        public WheatstoneMatrix matrix;
        private string fitter = "Z";
        private string keyWord;
        //private string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        private string alphabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,?";

        public Cipher(string keyWord)
        {
            this.keyWord = keyWord;
        }

        public string Code(string textToCode, int decode)
        {
            matrix = new WheatstoneMatrix(5, 8, keyWord.ToUpper(), alphabet);
            string codedText="";
            textToCode = Normalise(textToCode);
            if (textToCode.Length % 2 != 0)
                textToCode += fitter;
            for (int i=0; i<textToCode.Length-1; i+=2)
            {
                var X1 = matrix.IndexesOf(textToCode[i]).X;
                var Y1 = matrix.IndexesOf(textToCode[i]).Y;

                var X2 = matrix.IndexesOf(textToCode[i+1]).X;
                var Y2 = matrix.IndexesOf(textToCode[i+1]).Y;

                if (X1 == X2)
                {
                    codedText += matrix[X1 + 1 * decode, Y1].ToString();
                    codedText += matrix[X2 + 1 * decode, Y2].ToString();
                }
                
                if (Y1 == Y2)
                {
                    codedText += matrix[X1, Y1 - 1 * decode].ToString();
                    codedText += matrix[X2, Y2 - 1 * decode].ToString();
                }
                else
                if (Y1!=Y2 && X1!=X2)
                {
                    codedText += matrix[X2, Y1].ToString();
                    codedText += matrix[X1, Y2].ToString();
                }
            }
            return codedText;
        }

        private string Normalise(string line)
        {
            foreach (var ch in line)
            {
                if (!alphabet.Contains(ch.ToString()))
                    line=line.Replace(ch.ToString(), "");
            }

            for (int i=0; i<line.Length-1; i++)
            {
                if (line[i] == line[i + 1])
                    line =line.Insert(i + 1, fitter);
            }
            if (line.Length % 2 != 0)
                line += fitter;
            return line;
        }
    }
}

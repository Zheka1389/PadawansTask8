using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }
            if (text == "")
            {
                throw new ArgumentException();
            }
            char[] marks = { ' ', '.', ',', '!', '?', '-', ':', ';' };
            string[] s = text.Split(marks);
            bool breaker;
            for (int i = 0; i < s.Length; i++)
            {
                breaker = true;
                if (s[i] != "")
                {
                    foreach (char ch in s[i])
                    {
                        Console.Write(ch);
                        if (!((ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122)))
                        {
                            breaker = false;
                            break;
                        }
                    }
                    Console.WriteLine();
                    if (breaker)
                    {
                        for (int y = i + 1; y < s.Length; y++)
                        {
                            if (s[i].Equals(s[y]))
                            {
                                s[y] = "";
                            }
                        }
                    }
                }
            }
            int q = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length != 0)
                {
                    q = text.IndexOf(s[i]) + s[i].Length;
                    while (true)
                    {
                        q = text.IndexOf(s[i]) + s[i].Length;
                        if (text.IndexOf(s[i], q) == -1)
                            break;
                        text = text.Remove(text.IndexOf(s[i], q), s[i].Length);
                    }
                }
            }
        }
    }
}
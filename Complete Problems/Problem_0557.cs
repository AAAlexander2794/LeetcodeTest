using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0557
    {
        public class Solution
        {
            public string ReverseWords(string s)
            {
                if (s == null) return null;
                if (s == "" || s.Trim() == "") return "";
                //
                string result = "";
                //
                string word = "";
                //
                int i = 0;
                // 
                while (i < s.Length)
                {
                    //Console.Write(i + " ");
                    // Если пробел
                    if (s[i] == ' ')
                    {
                        
                        // Записываем полученное слово наоборот
                        result = AddWordReverse(word, result);
                        // Обнуляем
                        word = "";
                        // Добавляем пробел
                        result += ' ';
                    }
                    //
                    else
                    {
                        word += s[i];
                    }
                    //
                    i++;
                }
                if (word != "") result = AddWordReverse(word, result);
                return result;
            }

            string AddWordReverse(string word, string words)
            {
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    words += word[j];
                }
                return words;
            }
        }

        public class SolutionFirstTry
        {
            public string ReverseWords(string s)
            {
                if (s == null) return null;
                if (s == "") return "";
                var words = s.Split(' ');
                s = "";
                foreach (var word in words)
                {
                    if (word == null) continue;
                    if (word.Trim() == "") continue;
                    var ar = word.ToCharArray();
                    ReverseString(ar);
                    foreach (char c in ar)
                    {
                        s += c;
                    }
                    s += ' ';
                }
                s = s.Remove(s.Length - 1, 1);
                return s;
            }

            public void ReverseString(char[] s)
            {
                int half;
                if (s.Length % 2 == 0) half = s.Length / 2;
                else half = (s.Length - 1) / 2;
                for (int i = 0; i < half; i++)
                {
                    var a = s[i];
                    s[i] = s[s.Length - 1 - i];
                    s[s.Length - 1 - i] = a;
                }
            }
        }
    }
}

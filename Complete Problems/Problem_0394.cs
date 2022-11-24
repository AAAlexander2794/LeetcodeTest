using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0394
    {
        public class Solution
        {
            public string DecodeString(string s)
            {

                int i = s.Length - 1;
                Console.WriteLine($"{i} {s}");
                while (i >= 0)
                {
                    // Если наткнулись на цифру
                    if (char.IsDigit(s[i]))
                    {
                        // Сразу задаем, откуда будем смотреть буквы
                        int j = i + 1;
                        // Смотрим число
                        string digit = s[i].ToString();
                        while (i > 0)
                        {
                            if (char.IsDigit(s[i - 1]))
                            {
                                i--;
                                digit = s[i].ToString() + digit;
                            }
                            else break;
                        }
                        // Находим индекс первой после цифры закрывающей скобки
                        while (j < s.Length)
                        {
                            if (s[j] == ']') break;
                            j++;
                        }
                        string str = String.Concat(Enumerable.Repeat(s.Substring(i + digit.Length + 1, j - i - digit.Length - 1), int.Parse(digit)));
                        s = s.Remove(i, j - i + 1);
                        s = s.Insert(i, str);
                    }
                    i--;
                    Console.WriteLine($"{i} {s}");
                }
                return s;
            }
        }
    }
}

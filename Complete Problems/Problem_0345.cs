using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0345
    {
        public class Solution_2
        {
            public string ReverseVowels(string s)
            {
                char[] vowels = ['a', 'e', 'i', 'o', 'u'];
                string result = "";
                int j = s.Length - 1;
                //Stack<char> stack = new Stack<char>();
                //
                for (int i = 0; i < s.Length; i++)
                {
                    // Если гласная
                    if (vowels.Contains(char.ToLower(s[i])))
                    {
                        // Ищем гласную с другой стороны
                        while (j >= 0)
                        {
                            // Нашли гласную
                            if (vowels.Contains(char.ToLower(s[j])))
                            {
                                // Берем ее в результат
                                result += s[j];
                                // Переходим к следующей букве
                                j--;
                                // Выходим из цикла
                                break;
                            }
                            else { j--; }
                        }
                    }
                    else
                    {
                        result += s[i];
                    }
                }
                //
                return result;
            }
        }

        public class Solution_1
        {
            public string ReverseVowels(string s)
            {
                char[] vowels = ['a', 'e', 'i', 'o', 'u'];
                string result = "";
                Stack<char> stack = new Stack<char>();
                //
                foreach (var c in s)
                {
                    // Если гласная
                    if (vowels.Contains(char.ToLower(c)))
                    {
                        stack.Push(c);
                    }
                }
                //
                foreach (var c in s)
                {
                    // Если гласная
                    if (vowels.Contains(char.ToLower(c)))
                    {
                        result += stack.Pop();
                    }
                    else
                    {
                        result += c;
                    }
                }
                return result;
            }
        }
    }
}

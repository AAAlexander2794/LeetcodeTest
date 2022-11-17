using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Problems
{
    public partial class Solution
    {
        /// <summary>
        /// Done
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        /// <remarks>
        /// 1 <= s.length <= 15
        /// s contains only the characters('I', 'V', 'X', 'L', 'C', 'D', 'M').
        /// It is guaranteed that s is a valid roman numeral in the range[1, 3999].
        /// </remarks>
        public int RomanToInt(string s)
        {
            int sum = 0;
            // Ищу M
            char[] dictChars = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] dictInts = { 1, 5, 10, 50, 100, 500, 1000 };
            var chars = s.ToCharArray();
            // Проходим от большего к меньшему
            for (int i = dictChars.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"in {dictChars[i]}");
                //int lastPosition = 0;
                // Проходим в прямом порядке
                for (int j = 0; j < chars.Length; j++)
                {
                    Console.WriteLine($"in char {chars[j]}");
                    if (chars[j] == '0') 
                    {
                        Console.WriteLine($"continue {j}");
                        continue; 
                    }
                    // Если нашли символ
                    if (chars[j] == dictChars[i])
                    {
                        sum += dictInts[i];
                        Console.WriteLine($"found {chars[j]}, sum {sum}");
                        // Если перед найденным наибольшим символом есть еще символ и он не 0
                        if (j > 0 && chars[j-1] != '0')
                        {
                            // Отнимаем соответствующее значение предыдущего символа
                            var index = Array.IndexOf(dictChars, chars[j - 1]);
                            sum -= dictInts[index];
                            Console.WriteLine($"found {chars[j-1]}, sum {sum}");
                            //
                            chars[j - 1] = '0';
                        }
                        //
                        chars[j] = '0';
                    }
                }
            }
            return sum;
        }
    }
}

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
        /// <param name="x"></param>
        /// <returns></returns>
        /// <remarks>
        /// -231 <= x <= 231 - 1
        /// </remarks>
        public bool IsPalindrome(int x)
        {
            // Все отрицательные - не палиндромы
            if (x < 0) return false;
            //
            string input = x.ToString();
            // Все односимвольные - палиндромы
            if (input.Length == 1) return true;
            //
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reverseInput = new string(charArray);
            // Проверяем по всем символам
            for (int i = 0; i < input.Length; i++)
            {
                // Хоть одно несовпадение - не палиндром
                if (reverseInput[i] != input[i]) return false;
            }
            //
            return true;
        }
    }
}

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
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            // Идем по порядку символов
            int i = 0;
            while (true)
            {
                // 
                char? myChar = null;
                foreach (string str in strs)
                {
                    // Выходим
                    if (str.Length == i) return result;
                    //
                    if (myChar == null) myChar = str[i];
                    //
                    if (myChar != str[i]) return result;
                }
                // Если нас не выбросило, то этот символ во всех строках
                result += myChar;

                i++;
            }
        }
    }
}

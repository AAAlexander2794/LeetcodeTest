using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1957
    {
        /// <summary>
        /// Решение через StringBuilder - работает, но решение через массив char было бы гораздо быстрее.
        /// </summary>
        public class Solution
        {
            public string MakeFancyString(string s)
            {
                var sb = new StringBuilder(s);
                //
                int i = sb.Length - 2;
                char c = sb[i + 1];
                int count = 1;
                //
                while (i >= 0 ) 
                {
                    if (sb[i] == c)
                    {
                        if (count == 2)
                        {
                            sb.Remove(i, 1);
                            i--;
                        }
                        else
                        {
                            count++;
                            i--;
                        }
                    }
                    else
                    {
                        //
                        c = sb[i];
                        count = 1;
                        i--;
                    }
                }
                return sb.ToString();
            }
        }

        public class Solution_tooLong
        {
            public string MakeFancyString(string s)
            {

                //
                string result = "" + s[0];
                char c = s[0];
                int count = 1;
                //
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] == c)
                    {
                        if (count == 2)
                        {
                            continue;
                        }
                        else
                        {
                            result += s[i];
                            count++;
                        }
                    }
                    else
                    {
                        result += s[i];
                        //
                        c = s[i];
                        count = 1;
                    }
                }
                return result;
            }
        }
    }
}

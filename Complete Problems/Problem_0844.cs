using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0844
    {
        public class Solution
        {
            public bool BackspaceCompare(string s, string t)
            {
                while (s.Contains("#"))
                {
                    Console.WriteLine(s);
                    while (s != "" && s[0] == '#')
                    {
                        s = System.Text.RegularExpressions.Regex.Replace(s, $"^#", "");
                    }
                    s = System.Text.RegularExpressions.Regex.Replace(s, $"([a-zA-Z0-9])#", "");
                }
                Console.WriteLine(s);
                while (t.Contains("#"))
                {
                    Console.WriteLine(t);
                    while (t != "" && t[0] == '#')
                    {
                        t = System.Text.RegularExpressions.Regex.Replace(t, $"^#", "");
                    }
                    t = System.Text.RegularExpressions.Regex.Replace(t, $"([a-zA-Z0-9])#", "");
                }
                Console.WriteLine(t);

                return s.Equals(t);
            }
        }
    }
}

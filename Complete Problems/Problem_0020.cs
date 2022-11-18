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
        public bool IsValid(string s)
        {
            List<int> opens = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        opens.Add(1);
                        break;
                    case ')':
                        if (opens.Count ==0 || opens.Last() != 1) return false;
                        opens.RemoveAt(opens.Count - 1);                        
                        break;
                    case '[':
                        opens.Add(2);
                        break;
                    case']':
                        if (opens.Count == 0 || opens.Last() != 2) return false;
                        opens.RemoveAt(opens.Count - 1);
                        break;
                    case '{':
                        opens.Add(3);
                        break;
                    case '}':
                        if (opens.Count ==0 || opens.Last() != 3) return false;
                        opens.RemoveAt(opens.Count - 1);
                        break;
                }
            }
            if (opens.Count != 0) return false;
            else return true;
        }
    }
}

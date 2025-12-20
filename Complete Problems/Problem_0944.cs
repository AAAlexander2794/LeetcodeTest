using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0944
    {
        public class Solution
        {
            public int MinDeletionSize(string[] strs)
            {
                char[] currChar = strs[0].ToCharArray();
                HashSet<int> deletedColumns = new HashSet<int>();
                foreach (string str in strs)
                {
                    for (int i = 0; i < currChar.Length; i++)
                    {
                        if (deletedColumns.Contains(i))
                        {
                            continue;
                        }
                        if (currChar[i] > str[i])
                        {
                            deletedColumns.Add(i);
                        }
                        else
                        {
                            currChar[i] = str[i];
                        }
                    }
                }
                return deletedColumns.Count;
            }
        }
    }
}

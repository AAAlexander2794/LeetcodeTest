using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0383
    {
        public class Solution
        {
            public bool CanConstruct(string ransomNote, string magazine)
            {
                char?[] magChars = new char?[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    magChars[i] = magazine[i];
                }
                foreach (char letter in ransomNote)
                {
                    Console.Write(letter);
                    var flag = false;
                    for (int i = 0; i < magChars.Length; i++)
                    {
                        if (magChars[i] != null && magChars[i] == letter)
                        {
                            magChars[i] = null;
                            flag = true;
                            break;
                            Console.Write("true");
                        }
                    }
                    if (!flag) return false;
                }
                return true;
            }
        }
    }
}

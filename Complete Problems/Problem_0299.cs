using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0299
    {
        public class Solution
        {
            public string GetHint(string secret, string guess)
            {
                int bulls = 0;
                //
                int[] sChars = new int[10];
                int[] gChars = new int[10];
                // 
                for (int i = 0; i < secret.Length; i++)
                {
                    if (secret[i] == guess[i])
                    {
                        bulls++;
                    }
                    else
                    {
                        sChars[secret[i] - '0']++;
                        gChars[guess[i] - '0']++;
                    }
                }
                //
                int cows = 0;
                for (int i = 0; i < sChars.Length; i++)
                {
                    cows += Math.Min(sChars[i], gChars[i]);
                }
                return $"{bulls}A{cows}B";
            }
        }
    }
}

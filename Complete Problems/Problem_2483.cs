using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_2483
    {
        public class Solution
        {
            public int BestClosingTime(string customers)
            {
                var arr = customers;

                int numN = 0;
                int numY = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 'N') { numN++; }
                    if (arr[i] == 'Y') { numY++; }
                }

                int penalty = numY;
                int minPenalty = penalty;
                int hour = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == 'N') 
                    { 
                        penalty++; 
                    }
                    if (arr[j] == 'Y') 
                    { 
                        penalty--; 
                    }
                    if (penalty < minPenalty)
                    {
                        minPenalty = penalty;
                        hour = j + 1;
                    }
                }
                //
                return hour;

            }

            public int BestClosingTime1(string customers)
            {
                char[] arr = customers.ToCharArray();

                int numN = 0;
                int numY = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 'N') { numN++; }
                    if (arr[i] == 'Y') { numY++; }
                }

                int penalty = numY;
                int minPenalty = penalty;
                int hour = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == 'N')
                    {
                        penalty++;
                    }
                    if (arr[j] == 'Y')
                    {
                        penalty--;
                    }
                    if (penalty < minPenalty)
                    {
                        minPenalty = penalty;
                        hour = j + 1;
                    }
                }
                //
                return hour;

            }
        }
    }
}

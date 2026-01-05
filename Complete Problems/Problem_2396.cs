using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_2396
    {
        public class Solution
        {
            public bool IsStrictlyPalindromic(int n)
            {
                for (int i = 2; i <= n - 2; i++)
                {
                    var number = GetReverseNumberInBase(n, i);
                    if (NumberIsPalindrome(number) == false)
                    {
                        return false;
                    }
                }
                return true;
            }

            private List<int> GetReverseNumberInBase(int n, int newBase)
            {
                List<int> reverseNumber = new List<int>();
                while (n != 0)
                {
                    reverseNumber.Add(n % newBase);
                    n = n / newBase;
                }
                return reverseNumber;
            }

            private bool NumberIsPalindrome(List<int> number)
            {
                int start = 0;
                int end = number.Count - 1;
                while (start < end)
                {
                    if (number[start] != number[end])
                    {
                        return false;
                    }
                    start++;
                    end--;
                }
                return true;
            }
        }
    }
}

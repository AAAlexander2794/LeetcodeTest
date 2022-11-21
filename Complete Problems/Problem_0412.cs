using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0412
    {
        public class Solution
        {
            public IList<string> FizzBuzz(int n)
            {
                List<string> list = new List<string>();
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        list.Add("FizzBuzz");
                        continue;
                    }
                    if (i % 3 == 0)
                    {
                        list.Add("Fizz");
                        continue;
                    }
                    if (i % 5 == 0)
                    {
                        list.Add("Buzz");
                        continue;
                    }
                    list.Add(i.ToString());
                }
                return list;
            }
        }
    }
}

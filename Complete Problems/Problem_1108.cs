using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_1108
    {
        public class Solution
        {
            public string DefangIPaddr(string address)
            {
                return address.Replace(".", "[.]");
            }
        }
    }
}

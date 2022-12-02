using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_2469
    {
        public class Solution
        {
            public double[] ConvertTemperature(double celsius)
            {
                var Kelvin = celsius + 273.15;
                var Fahrenheit = celsius * 1.80 + 32.00;
                double[] ans = { Kelvin, Fahrenheit };
                return ans;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3606
    {
        public class Solution
        {
            public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
            {
                //
                char[] validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_0123456789".ToCharArray();
                //
                List<string> result = new List<string>();
                //
                List<string> electronics = new List<string>();
                List<string> grocery = new List<string>();
                List<string> pharmacy = new List<string>();
                List<string> restaurant = new List<string>();
                //
                for (int i = 0; i < code.Length; i++)
                {
                    bool codeIsValid = true;
                    if (code[i] == "") { continue; }
                    foreach (char c in code[i])
                    {
                        if (!validChars.Contains(c))
                        {
                            codeIsValid = false;
                            break;
                        }
                    }
                    if (codeIsValid == false || isActive[i]  == false)
                    {
                        continue;
                    }
                    //
                    switch (businessLine[i])
                    {
                        case "electronics":
                            electronics.Add(code[i]);
                            break;
                        case "grocery":
                            grocery.Add(code[i]);
                            break;
                        case "pharmacy":
                            pharmacy.Add(code[i]);
                            break;
                        case "restaurant":
                            restaurant.Add(code[i]);
                            break;
                        default:
                            continue;
                    }
                }
                //
                MyComparer myComp = new MyComparer();
                //
                electronics.Sort(myComp);
                grocery.Sort(myComp);
                pharmacy.Sort(myComp);
                restaurant.Sort(myComp);
                //
                foreach (var item in electronics) { result.Add(item); }
                foreach (var item in grocery) { result.Add(item); }
                foreach (var item in pharmacy) { result.Add(item); }
                foreach (var item in restaurant) { result.Add(item); }
                //
                return result;
            }

            public class MyComparer : IComparer<string>
            {
                public int Compare(string? x, string? y)
                {
                    return string.Compare(x, y, StringComparison.Ordinal);

                }
            }

        }
    }
}

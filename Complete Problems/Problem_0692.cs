using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0692
    {
        public class Solution
        {
            public IList<string> TopKFrequent(string[] words, int k)
            {
                IDictionary<string, int> pairs = new Dictionary<string, int>();
                foreach (string word in words)
                {
                    if (pairs.ContainsKey(word)) pairs[word]++;
                    else pairs.Add(word, 1);
                }
                List<string> list = new List<string>();
                //
                while (k > 0)
                {
                    var temp = pairs.Where(x => x.Value == pairs.Values.Max());
                    //foreach (var item in temp) Console.WriteLine($"{item}");
                    //Console.WriteLine(k);
                    List<string> tempList = new List<string>();
                    foreach (var item in temp) tempList.Add(item.Key);
                    //foreach (var item in tempList) Console.WriteLine($"{item}");

                    //Console.WriteLine("***");
                    //foreach (var item in tempList) Console.WriteLine($"{item}");
                    //Console.WriteLine(k);
                    tempList.Sort();
                    //foreach (var item in tempList) Console.WriteLine($"{item}");
                    //Console.WriteLine(k);

                    foreach (var item in tempList)
                    {
                        if (k > 0)
                        {
                            list.Add(item);
                            pairs.Remove(item);
                            k--;
                        }
                        else return list;
                    }
                    //foreach (var item in pairs) Console.WriteLine($"{item.Value} {item.Key}");
                }

                return list;
            }
        }
    }
}

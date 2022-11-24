using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0438
    {
        public class Solution
        {
            public IList<int> FindAnagrams(string s, string p)
            {

                IList<int> result = new List<int>();

                int[] chars = new int[26];

                if (s.Length < p.Length) return result;

                int[] sChars = new int[26];
                int[] pChars = new int[26];

                for (int i = 0; i < p.Length; i++)
                {
                    sChars[s[i] - 'a']++;
                }

                foreach (var c in p)
                {
                    pChars[c - 'a']++;
                }

                for (int i = 0; i < s.Length - p.Length; i++)
                {
                    if (sChars.SequenceEqual(pChars)) result.Add(i);
                    sChars[s[i] - 'a']--;
                    sChars[s[i + p.Length] - 'a']++;
                }
                if (sChars.SequenceEqual(pChars)) result.Add(i);
                return result;
            }

            public IList<int> FindAnagramsLongTime(string s, string p)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < s.Length - p.Length + 1; i++)
                {
                    if (p.Contains(s[i]))
                    {
                        var chars = p.ToCharArray().ToList();
                        for (int j = i; j < i + p.Length; j++)
                        {
                            // Если не найден, выходим
                            if (!chars.Remove(s[j])) break;
                            // Если все буквы закончились, пишем в результат
                            if (chars.Count == 0) result.Add(i);
                        }
                    }
                }
                return result;
            }
        }
    }
}

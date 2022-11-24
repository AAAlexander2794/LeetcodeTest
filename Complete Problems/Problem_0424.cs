using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0424
    {
        public class Solution
        {
            public int CharacterReplacement(string s, int k)
            {

                // Максимальная длина ну точно не меньше (k + 1)
                int maxLength = k + 1;
                //

                int[] chars = new int[26];
                
                for (int i = 0; i < maxLength; i++)
                {
                    chars[s[i] - 'A']++;
                }

                //
                int start = 0;
                int end = maxLength - 1;
                while (end < s.Length)
                {
                    // Расширили вправо
                    end++;
                    if (end < s.Length) chars[s[end] - 'A']++;
                    // Если результат прежний или  улучшился, то записываем и старт оставляем, где был
                    if (chars.Sum() - chars.Max() <= k && chars.Sum() >= maxLength)
                    {
                        maxLength = chars.Sum();
                    }
                    // Если результат хуже, то левый край переезжает
                    else
                    {
                        chars[s[start] - 'A']--;
                        start++;
                    }
                }
                return maxLength;
            }

            public int CharacterReplacementLongTime(string s, int k)
            {
                
                // Максимальная длина
                int maxLength = 0;
                //
                //int maxOfSameLetters = 0;
                //
                int[] sChars = new int[26];
                foreach (char c in s)
                {
                    sChars[c - 'A']++;
                    //if (sChars[c - 'A'] > maxOfSameLetters) maxOfSameLetters = sChars[c - 'A'];
                }
                //
                int start = 0;
                int end = s.Length - 1;
                while (end - start >= 0)
                {
                    for (int i = 0; i < sChars.Length; i++)
                    {
                        sChars[i] = 0;
                    }
                    for (int i = start; i <= end; i++)
                    {
                        sChars[s[i] - 'A']++;
                    }
                    while (end < s.Length)
                    {
                        Console.WriteLine($"{start} {end}");
                        if (sChars.Sum() - sChars.Max() <= k && sChars.Sum() > maxLength)
                        {
                            maxLength = sChars.Sum();
                        }
                        sChars[s[start] - 'A']--;
                        start++;
                        end++;
                        if (end < s.Length) sChars[s[end] - 'A']++;
                    }
                    int length = end - start;
                    start = 0;
                    end = start + length - 1;
                }
                


                return maxLength;
            }
        }
    }
}

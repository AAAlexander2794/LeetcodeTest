using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0567
    {
        public class Solution
        {
            public bool CheckInclusion(string s1, string s2)
            {
                if (s1.Length > s2.Length) return false;
                int[] ar1 = new int[26];
                foreach (var c in s1)
                {
                    ar1[c - 'a']++;
                }
                // Заполняем символами второго слова по размеру первого слова
                int[] ar2 = new int[26];
                int i = 0;
                while (i < s1.Length)
                {
                    ar2[s2[i] - 'a']++;
                    i++;
                }
                i--;
                //
                int j = 0;
                while (i < s2.Length)
                {
                    // Проверка на совпадение букв
                    bool flag = true;
                    for (int k = 0; k < ar1.Length; k++)
                    {

                        if (ar1[k] != ar2[k])
                        {
                            flag = false;
                        }
                    }
                    
                    // Если совпали, заканчиваем
                    if (flag) return true;
                    // Если не совпали, двигаем диапазон правее
                    ar2[s2[j] - 'a']--;
                    j++;
                    i++;
                    if (i < s2.Length) ar2[s2[i] - 'a']++;
                }
                return false;
            }
        }
    }
}

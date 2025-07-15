using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_3136
    {
        public class Solution_2
        {
            public bool IsValid(string word)
            {
                if (word.Length < 3) { return false; }
                bool flagVowels = false;
                bool flagAlpha = false;
                char[] vowels = ['A', 'E', 'I', 'O', 'U'];
                char[] alpha = "BCDFGHJKLMNPQRSTVWXYZ".ToCharArray();
                foreach (var item in word)
                {
                    if (item == '@' || item == '#' || item == '$' ) { return false; }
                    if (!flagVowels && vowels.Contains(char.ToUpper(item))) { flagVowels = true; }
                    if (!flagAlpha && alpha.Contains(char.ToUpper(item))) { flagAlpha = true; }
                }
                return flagVowels && flagAlpha;
            }
        }

        public class Solution_1
        {
            public bool IsValid(string word)
            {
                if (word.Length < 3) { return false; }
                if (word.Contains('@') ||
                    word.Contains('#') ||
                    word.Contains('$')) { return false; }
                word = word.ToUpper();
                char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
                char[] alpha = "BCDFGHJKLMNPQRSTVWXYZ".ToCharArray();
                bool flagVowels = false;
                bool flagAlpha = false;
                foreach (var c in vowels)
                {
                    if (word.Contains(c))
                    {
                        flagVowels = true;
                        break;
                    }
                }
                foreach (var c in alpha)
                {
                    if (word.Contains(c))
                    {
                        flagAlpha = true;
                        break;
                    }
                }
                return flagVowels && flagAlpha;
            }
        }
    }
}

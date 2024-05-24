using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1071
    {
        public class Solution
        {
            public string GcdOfStrings(string str1, string str2)
            {
                ///<remarks>
                /// Пример:
                /// str1 = "ABABAB"
                /// str2 = "ABAB"
                /// Тогда
                /// x = "AB"
                /// 
                /// Получается, 
                /// str1 = n1 * x, 
                /// str2 = n2 * x.
                /// Сначала найдем Min(n1 * x, n2 * x)
                /// </remarks>
                
                
                // Если строки равны, то они из самих себя и состоят
                if (str1 == str2) return str1;
                // Переменная, которую ищем
                string x = "";
                // Найдем минимальную длину из двух строк
                int length = Math.Min(str1.Length, str2.Length);
                // Если минимальная длина строк посимвольно не совпадают, то x = ""
                if (str1.Substring(0, length) != str2.Substring(0, length)) return "";
                // x может быть равен или меньше, чем строка минимальной длины
                x = str1.Substring(0, length);
                // Идем на уменьшение
                for (int i = length; i > 0; i--)
                {
                    // i - текущая длина рассматриваемой подстроки
                    
                    // Флаги, которые, если становятся одновременно true, то нашли x
                    bool flag1 = false, flag2 = false;
                    // Длина строк должна быть кратна i
                    if (str1.Length % i == 0 && str2.Length % i == 0)
                    {
                        // Определяем блок x
                        x = x[..i];
                        // Если str1 состоит из блоков x
                        if (str1 == string.Concat(Enumerable.Repeat(x, str1.Length / i)))
                        {
                            flag1 = true;
                        }
                        // То же с str2
                        if (str2 == string.Concat(Enumerable.Repeat(x, str2.Length / i)))
                        {
                            flag2 = true;
                        }
                        // Если оба флага true
                        if (flag1 && flag2) return x;
                    }
                    else continue;
                }
                //
                return "";
            }
        }
    }
}

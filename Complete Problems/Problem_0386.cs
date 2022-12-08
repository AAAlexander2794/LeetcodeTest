using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest.Contests.Warm_Up_Contest
{
    internal class Problem_0386
    {
        public class Solution
        {
            public IList<int> LexicalOrder(int n)
            {
                var list = new List<int>();
                // 
                New(1, n, list);
                //
                return list;
            }

            List<int> New(int i, int n, List<int> list)
            {
                
                if (list.Count < n)
                {
                    list.Add(i);
                    // Сначала делаем все возможные умножения
                    if (i * 10 <= n)
                    {
                        // Умножаем на 10
                        New(i * 10, n, list);
                    }
                    // Если не превышает главного числа и не вылезли за 9
                    if (i + 1 <= n && (i + 1) % 10 != 0)
                    {
                        // Увеличиваем на 1
                        New(i + 1, n, list);
                    }                 
                }
                return list;
            }
        }
    }
}

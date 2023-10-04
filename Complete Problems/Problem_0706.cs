using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0706
    {
        public class MyHashMap
        {
            public Dictionary<int, int> Map { get; set; }

            public MyHashMap()
            {
                Map = new Dictionary<int, int>();
            }

            public void Put(int key, int value)
            {
                if (Map == null) return;
                if (Map.ContainsKey(key))
                {
                    Map[key] = value;
                }
                else
                {
                    Map.Add(key, value);
                }
            }

            public int Get(int key)
            {
                if (!Map.ContainsKey(key)) return -1;
                return Map[key];
            }

            public void Remove(int key)
            {
                if (Map.ContainsKey(key))
                {
                    Map.Remove(key);
                }
            }
        }

        /**
         * Your MyHashMap object will be instantiated and called as such:
         * MyHashMap obj = new MyHashMap();
         * obj.Put(key,value);
         * int param_2 = obj.Get(key);
         * obj.Remove(key);
         */
    }
}

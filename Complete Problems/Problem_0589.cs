using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0589
    {
        
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}


        public class Solution
        {
            public IList<int> Preorder(Node root)
            {
                
                List<int> result = new List<int>();
                if (root == null) return result;
                List<Node> list = root.children.ToList();
                
                result.Add(root.val);
                while (list.Count > 0)
                {
                    var item = list.First();
                    result.Add(item.val);
                    if (item.children != null)
                    {
                        int index = 1;
                        foreach (var child in item.children)
                        {
                            list.Insert(index, child);
                            index++;
                        }
                    }
                    list.RemoveAt(0);
                }
                return result;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetcodeTest._Not_Complete_Problems.Problem_0589;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0116
    {
        
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}


        public class Solution
        {
            public Node Connect(Node root)
            {
                //var node = root;
                if (root == null) return null;
                Do(root);
                return root;
            }

            void Do(Node node)
            {
                if (node.left != null && node.right != null)
                {
                    node.left.next = node.right;
                }
                // Если следующая есть
                if (node.next != null)
                {
                    // Если у следующей есть левая
                    if (node.next.left != null)
                    {
                        // Если у этой есть правая
                        if (node.right != null)
                        {
                            node.right.next = node.next.left;
                        }
                        // Иначе если есть левая
                        else if (node.left != null)
                        {
                            node.left.next = node.next.left;
                        }
                    }
                    // Иначе если у следующей есть правая
                    else if (node.next.right != null)
                    {
                        // Если у этой есть правая
                        if (node.right != null)
                        {
                            node.right.next = node.next.right;
                        }
                        // Иначе если есть левая
                        else if (node.left != null)
                        {
                            node.left.next = node.next.right;
                        }
                    }
                }
                if (node.left != null) Do(node.left);
                if (node.right != null) Do(node.right);
            }
        }
    }
}

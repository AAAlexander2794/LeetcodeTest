using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0094
    {
        /**
 * Definition for a binary tree node.
 
 */
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            public IList<int> InorderTraversal(TreeNode root)
            {
                List<int> list = new List<int>();
                if (root == null) return list;
                Do(list, root);
                return list;
            }

            public List<int> Do(List<int> list, TreeNode node)
            {

                if (node.left != null)
                {
                    Do(list, node.left);
                }
                list.Add(node.val);
                if (node.right != null)
                {
                    Do(list, node.right);
                }
                return list;
            }
        }
    }
}

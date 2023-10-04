using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0104
    {
        /**
 // Definition for a binary tree node.
  
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
            public int MaxDepth(TreeNode root)
            {
                if (root == null) return 0;
                
                int one = MaxDepth(root.left);
                int two = MaxDepth(root.right);
                if (one >= two) return one + 1;
                else return two + 1;
                return Math.Max(one, two) + 1;
            }
        }
    }
}

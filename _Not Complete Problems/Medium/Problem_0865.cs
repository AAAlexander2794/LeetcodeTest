using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_0865
    {

        //* Definition for a binary tree node.
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
            public TreeNode SubtreeWithAllDeepest(TreeNode root)
            {
                int maxDepth = GetDepth(root);
                var a = 1;
                return root;
            }

            private int GetDepth(TreeNode root)
            {
                int leftDepth = 0;
                int rightDepth = 0;
                if (root.left != null)
                {
                    leftDepth = GetDepth(root.left);
                }
                if (root.right != null)
                {
                    rightDepth = GetDepth(root.right);
                }
                return Math.Max(leftDepth, rightDepth) + 1;
            }

        }
    }
}

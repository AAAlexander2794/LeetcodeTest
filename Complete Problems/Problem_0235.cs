using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0235
    {
        
 // Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 

        public class Solution
        {
           

            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
                if (root == null) return null;
                if (root.val > p.val && root.val > q.val)
                {
                    return LowestCommonAncestor(root.left, p, q);
                }
                if (root.val < p.val && root.val < q.val)
                {
                    return LowestCommonAncestor(root.right, p, q);
                }
                else return root;
            }

           
        }
    }
}

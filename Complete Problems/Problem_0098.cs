using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetcodeTest._Not_Complete_Problems.Problem_0102;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0098
    {
       
 //* Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
        public class Solution
        {
            public bool IsValidBST(TreeNode root)
            {
                return IsValidBstUtil(root, null, null);
            }

            private bool IsValidBstUtil(TreeNode node, int? min, int? max)
            {
                if (node == null)
                {
                    return true;
                }
                if ((min != null && node.val <= min.Value) || (max != null && node.val >= max.Value))
                {
                    return false;
                }
                return IsValidBstUtil(node.left, min, node.val) &&
                        IsValidBstUtil(node.right, node.val, max);
            }
        }
    }
}

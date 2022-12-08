using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0938
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
            public int RangeSumBST(TreeNode root, int low, int high)
            {
                int sum = 0;
                if (root.val >= low && root.val <= high) sum += root.val;
                if (root.left != null) sum += RangeSumBST(root.left, low, high);
                if (root.right != null) sum += RangeSumBST(root.right, low, high);
                return sum;
            }
        }
    }
}

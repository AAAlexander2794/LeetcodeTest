using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetcodeTest._Not_Complete_Problems.Medium
{
    internal class Problem_1026
    {
        
 // Definition for a binary tree node.
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
            

            public int MaxAncestorDiff(TreeNode root)
            {
                
                return Go(root, root.val, root.val);
                
            }

            int Go(TreeNode node, int min, int max)
            {
                int result1 = 0, result2 = 0;
                if (node.val < min) min = node.val;
                if (node.val > max) max = node.val;
                int result = Math.Abs(max - min);
                Console.Write($"{result} ");
                if (node.left != null) result1 = Go(node.left, min, max);
                if (node.right != null) result2 = Go(node.right, min, max);
                if (result1 > result) result = result1;
                if (result2 > result) result = result2;
                return result;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0617
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
            public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
            {
                if (root1 == null) return root2;
                if (root2 == null) return root1;
                root1.val += root2.val;
                //TreeNode result = new TreeNode(root1.val + root2.val);


                root1.left = MergeTrees(root1.left, root2.left);
                root1.right = MergeTrees(root1.right, root2.right);

                return root1;
            }

            
        }

        public class SolutionFirstTry
        {
            public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
            {
                if (root1 == null) return root2;
                if (root2 == null) return root1;
                TreeNode result = new TreeNode(root1.val + root2.val);


                result.left = MergeTrees(root1.left, root2.left);
                result.right = MergeTrees(root1.right, root2.right);

                return result;
            }


        }
    }
}

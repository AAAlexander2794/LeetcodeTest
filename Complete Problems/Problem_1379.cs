using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_1379
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
            public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
            {
                // Если получены пустые ссылки
                if (original == null || cloned == null) return null;
                // Если обнаружена цель
                if (original == target) return cloned;
                // Если цель не обнаружена, отправляем дальше по левой ветке
                if (original.left != null && GetTargetCopy(original.left, cloned.left, target) != null) return GetTargetCopy(original.left, cloned.left, target);
                //
                if (original.right != null && GetTargetCopy(original.right, cloned.right, target) != null) return GetTargetCopy(original.right, cloned.right, target);
                //
                return null;
            }
        }
    }
}

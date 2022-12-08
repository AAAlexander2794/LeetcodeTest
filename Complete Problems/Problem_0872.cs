using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems.Easy
{
    internal class Problem_0872
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
            public bool LeafSimilar(TreeNode root1, TreeNode root2)
            {
                List<int> list1 = new List<int>();
                List<int> list2 = new List<int>();
                GetTreeLeafs(root1, list1);
                GetTreeLeafs(root2, list2);
                if (list1.Count == list2.Count)
                {
                    for (int i = 0; i < list1.Count; i++)
                    {
                        if (list1[i] != list2[i]) return false;
                    }
                    return true;
                }
                return false;
            }

            List<int> GetTreeLeafs(TreeNode node, List<int> leafs)
            {
                if (node.left == null && node.right == null)
                {
                    leafs.Add(node.val);
                    return leafs;
                }
                if (node.left != null)
                {
                    GetTreeLeafs(node.left, leafs);
                }
                if (node.right != null)
                {
                    GetTreeLeafs(node.right, leafs);
                }
                return leafs;
            }
        }
    }
}

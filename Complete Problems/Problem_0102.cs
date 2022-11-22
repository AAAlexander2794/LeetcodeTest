using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0102
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
            public IList<IList<int>> LevelOrder(TreeNode root)
            {
                List<IList<int>> result = new List<IList<int>>();
                
                
                List<TreeNode> nodes = new List<TreeNode>();
                if (root == null) return result;
                nodes.Add(root);
                
                while (nodes.Count > 0)
                {
                    List<int> list = new List<int>();
                    List<TreeNode> nextNodes = new List<TreeNode>();
                    while (nodes.Count > 0)
                    {
                        var node = nodes.First();
                        list.Add(node.val);
                        if (node.left != null) nextNodes.Add(node.left);
                        if (node.right != null) nextNodes.Add(node.right);
                        nodes.RemoveAt(0);
                    }
                    result.Add(list);
                    nodes = nextNodes;
                }


                return result;
            }
        }
    }
}

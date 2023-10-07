// https://leetcode.com/problems/leaf-similar-trees/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private void Dfs(TreeNode root, List<int> leafs)
    {
        if(root != null)
        {
            if(root.left == null && root.right == null)
            {
                leafs.Add(root.val);
            }

            Dfs(root.left, leafs);
            Dfs(root.right, leafs);
        }
    }
     
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> leafs1 = new List<int>();
        List<int> leafs2 = new List<int>();

        Dfs(root1, leafs1);
        Dfs(root2, leafs2);

        return leafs1.SequenceEqual(leafs2);
    }
}
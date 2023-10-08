// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    private TreeNode dfs(TreeNode node, TreeNode p, TreeNode q)
    {
        if(node == null) return null;

        if(node == p || node == q) return node;

        TreeNode left = dfs(node.left, p , q);
        TreeNode right = dfs(node.right, p , q);

        if(left != null && right != null) return node;

        return left ?? right;

    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        return dfs(root, p ,q);
    }
}
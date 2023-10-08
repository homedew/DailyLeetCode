// https://leetcode.com/problems/longest-zigzag-path-in-a-binary-tree
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
    int count = 0;
    public void dfs(TreeNode node, int left, int right)
    {
        if(node == null) return;
        count = Math.Max(count, Math.Max(left, right));

        dfs(node.left, right + 1, 0);
        dfs(node.right, 0, left + 1);

    }

    public int LongestZigZag(TreeNode root) {
        dfs(root, 0 , 0);

        return count;
    }
}
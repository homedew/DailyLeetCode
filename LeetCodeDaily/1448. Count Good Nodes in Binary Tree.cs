// https://leetcode.com/problems/count-good-nodes-in-binary-tree/
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
    private int maxNum = 0;
    private void dfs(TreeNode node, int max)
    {
        if(node == null) return;

        if(max <= node.val)
        {
            maxNum++;
        }

        max = Math.Max(node.val, max);
        dfs(node.left, max);
        dfs(node.right, max);
    }

    public int GoodNodes(TreeNode root) {
        dfs(root, Int32.MinValue);
        return maxNum;
    }
}
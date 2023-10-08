// https://leetcode.com/problems/path-sum-iii

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
    int k = 0;
    Dictionary<long ,int> h = new Dictionary<long ,int>();
    private void dfs(TreeNode node, long currentSum)
    {
        if(node == null) return;

        currentSum += node.val;
        if(currentSum == k) count++;

        count += h.ContainsKey(currentSum - k) ? h[currentSum - k] : 0;

        if(h.ContainsKey(currentSum))
        {
            h[currentSum] = h[currentSum] + 1;
        } else {
            h[currentSum] =  1;
        }

        dfs(node.left, currentSum);
        dfs(node.right, currentSum);

        if(h.ContainsKey(currentSum))
        {
            h[currentSum] = h[currentSum] - 1;
        } 

    }

    public int PathSum(TreeNode root, int targetSum) {
        k = targetSum;
        dfs(root, 0);

        return count;
    }
}
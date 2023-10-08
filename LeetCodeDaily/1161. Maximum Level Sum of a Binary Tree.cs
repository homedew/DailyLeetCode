// https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree

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
    public int MaxLevelSum(TreeNode root) {
        int result = 0;
        int level = 0;
        Queue<TreeNode> queue  = new Queue<TreeNode>();
        queue.Enqueue(root);
        int max = Int32.MinValue;

        while(queue.Count > 0)
        {
            level++;
            int sum = 0;
            int count = queue.Count();
            for(int i  = 0; i < count ; i++)
            {
               var currentNode = queue.Dequeue();
               sum+= currentNode.val;

                if(currentNode.left != null)
                {
                  queue.Enqueue(currentNode.left);
                }

                if(currentNode.right != null)
                {
                   queue.Enqueue(currentNode.right);
                }

            }
            if(max < sum)
            {
                max = sum;
                result= level;
            }
        }

        return result;
    }
}
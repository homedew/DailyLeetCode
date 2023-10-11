
// https://leetcode.com/problems/delete-node-in-a-bst/

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
    public int Successor(TreeNode root)
    {
        root = root.right;
        while(root.left != null) {
            root = root.left;
        }

        return root.val;
    }

    public int Predecessor(TreeNode root)
    {
        root = root.left;
        while(root.right != null) {
            root = root.right;
        }

        return root.val;
    }


    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null) return null;

        if(key < root.val) root.left = DeleteNode(root.left, key);

        else if(key > root.val) root.right = DeleteNode(root.right, key);

        else {
            if(root.left == null && root.right == null) root = null;

            else if(root.right != null) {
                root.val = Successor(root);
                root.right = DeleteNode(root.right, root.val);
            } else {
                root.val = Predecessor(root);
                root.left = DeleteNode(root.left, root.val);
            }
        }

        return root;


    }
}
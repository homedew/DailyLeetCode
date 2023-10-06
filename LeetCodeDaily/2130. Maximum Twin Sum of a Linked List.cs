// https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int PairSum(ListNode head) {
        List<int> listNodeVal = new List<int>();
        while(head !=null)
        {
            listNodeVal.Add(head.val);
            head = head.next;
        }

        int i  = 0, j = listNodeVal.Count - 1;
        int max = 0;
        while(i < j)
        {
            max = Math.Max(max, listNodeVal[i] + listNodeVal[j]);
            i++;
            j--;
        }

        return max;

    }
}
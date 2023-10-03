//https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/
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
    public ListNode DeleteMiddle(ListNode head) {

        if(head.next == null) return null;
        int count = 0;
        ListNode p1 = head; // 1 pass
        ListNode p2 = head; // 2 pass

        while(p1 != null)
        {
            count++;
            p1 = p1.next;
        }

        int middle = count / 2;

        Console.WriteLine(middle);

        for(int i = 0 ; i < middle - 1; i++)
        {
            p2 = p2.next;
        }

        p2.next = p2.next.next;

        return head;
    }
}
// https://leetcode.com/problems/reverse-linked-list

// Using iterative 
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
    public ListNode ReverseList(ListNode head) {
        ListNode prevNode = null;
        ListNode curr = head;

        while(curr != null)
        {
            ListNode nextTemp = curr.next;
            curr.next = prevNode;
            prevNode = curr;
            curr = nextTemp;
        }

        return prevNode;
    }
}

// Another solution using recursive
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
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null) return head;

        ListNode p = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        
        return p;
    }
}
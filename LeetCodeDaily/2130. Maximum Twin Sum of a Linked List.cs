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

// using stack
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
        Stack<int> stackVal = new Stack<int>();
        ListNode current = head;
        while(head !=null)
        {
            stackVal.Push(head.val);
            head = head.next;
        }

        int i  = 0, j = stackVal.Count;
        int max = 0;
        while(i < j / 2)
        {
            max = Math.Max(max, current.val + stackVal.Pop());
            current = current.next;
            i++;
        }

        return max;

    }
}



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
        // find middle of the linkedlist
        ListNode slow = head;
        ListNode fast = head;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        // reverse from the middle

        ListNode tempNextNode, pre = null;
        while(slow != null)
        {
            tempNextNode= slow.next;
            slow.next = pre;
            pre = slow;
            slow = tempNextNode;
        }

        // then find max from origin and reverse
        ListNode start = head;
        int max = 0;
        while(pre != null)
        {
            max = Math.Max(max, start.val + pre.val);
            pre = pre.next;
            start = start.next;
        }

        return max;

    }
}
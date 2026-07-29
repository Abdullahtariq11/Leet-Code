/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode partition(ListNode head, int x) {
        if(head == null){
            return null;
        }
        ListNode lesserHead= new ListNode(0);
        ListNode greaterHead= new ListNode(0);

        ListNode less=lesserHead;
        ListNode greater=greaterHead;
        ListNode temp=head;
        while (temp!=null){
            if(temp.val>=x){
                greater.next=temp;
                greater=greater.next;
            }
            else{
                less.next=temp;
                less=less.next;
            }
            temp=temp.next;
        }
        greater.next=null;
        less.next=greaterHead.next;

        return lesserHead.next;

    }
}
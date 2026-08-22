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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        //Recursion way           
           if(list1 == null)
           {
             return list2;
           }
            if(list2 == null)
              return list1;

            if(list1.val <= list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        /* Using extra o(1) space variable to keep the hold of list;
        ListNode sortedListHead = new ListNode();
        ListNode curr = sortedListHead;
        while(list1 != null && list2 != null)
            {               
                    if(list1.val > list2.val)
                    {
                      curr.next = list2;
                      list2 = list2.next;
                    }                 
                    else
                    {
                      curr.next = list1;
                      list1 = list1.next;
                    }

                    curr = curr.next;
                              
            }
         if(list1== null)
         {
            curr.next = list2;
         }
         else
         {
            curr.next = list1;
         }

         return sortedListHead.next; */
    }
}
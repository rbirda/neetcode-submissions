/**
 * Definition for singly-linked list.

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
     }
  }
   */
 
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
     var newHeadNode = new ListNode(-1); 
     ListNode prev = null;      
        if (head == null)
         return null;
        newHeadNode = head;
         while(newHeadNode != null)
         {
            var temp = newHeadNode.next;          
            newHeadNode.next = prev;
            prev = newHeadNode;
            newHeadNode = temp;
         }        

         
         
      return prev;
      /*  var newHeadNode = new ListNode(-1);       
        if (head == null)
         return null;
         newHeadNode = head;
         if( head.next != null)
         {            
            newHeadNode = ReverseList(head.next);
            head.next.next = head;           
                     
         }

        head.next = null;
        return newHeadNode; */
    }
}

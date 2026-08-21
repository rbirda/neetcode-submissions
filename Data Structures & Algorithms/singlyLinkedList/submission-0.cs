public class LinkedList {
    
    ListNode head ;
    ListNode tail;

    public LinkedList() {

        head = new ListNode(-1);
        tail = head;

    }

    public int Get(int index) {
        ListNode curr = head.nextpointer;
        int i = 0;
        while (curr != null) {
            if (i == index) {
                return curr.val;
            }
            i++;
            curr = curr.nextpointer;
        }
        return -1; 

    }

    public void InsertHead(int val) {

        var newNode = new ListNode(val);
        newNode.nextpointer =  head.nextpointer;
        head.nextpointer = newNode;
        if(newNode.nextpointer ==null)
          tail = newNode;

    }

    public void InsertTail(int val) {
      
      var next = new ListNode(val);
       this.tail.nextpointer = next;
       this.tail = next;
       

    }

    public bool Remove(int index) {
       int currentIndex =0;
       var current = new ListNode(0);
       current = head;

       while(index > currentIndex && current != null)
       {
            current = current.nextpointer;
            currentIndex ++;
       }
       if(current != null && current.nextpointer!=null)
       {
          if(current.nextpointer == this.tail)
          {
                this.tail = current;
          }
          current.nextpointer = current.nextpointer.nextpointer;
          return true;
       }

       return false;
    }

    public List<int> GetValues() {
        List<int> res = new List<int>();
        ListNode curr = this.head.nextpointer;
        while (curr != null) {
            res.Add(curr.val);
            curr = curr.nextpointer;
        }
        return res;
    }
}

public class ListNode {
  
  public int val;
  public ListNode nextpointer;

    public ListNode( int val)
    {
        this.val = val;
        this.nextpointer = null;
    }
}




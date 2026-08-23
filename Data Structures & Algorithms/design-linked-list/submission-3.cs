public class MyLinkedList {
    ListNode head;
    ListNode tail;
    int size;

    public MyLinkedList() {
        head = null;
        tail = null;   
        size =0; 
    }

    public int Get(int index) {
        if (index < 0 || index >= size) 
        return -1;

        var currentIndex = 0;
        var movingNode = head;
        while (currentIndex < index && movingNode != null) {
           
            movingNode = movingNode.next;
            currentIndex++;
        }

        return movingNode.val;
    }

    public void AddAtHead(int val) {
        var newHead = new ListNode(val);
        if(head == null && tail == null)
          head = tail = newHead;
        else{
        newHead.next = head;
        head.prev = newHead;
        newHead.prev = null;
        head = newHead;
        }

        size++;
    }

    public void AddAtTail(int val) {
        var newNode = new ListNode(val);
        if(head == null && tail == null)
        {
          head = tail = newNode;
        }
        else
        {
            tail.next = newNode;
            newNode.prev = tail;
            tail = tail.next;
        }

        size++;
    }

    public void AddAtIndex(int index, int val) {

        if (index < 0 || index > size) 
        return;


        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        if(index == size)
        {
            AddAtTail(val);
            return;
        }

        var insertionNode = new ListNode(val);
        var movingNode = head;
        int currentIndex = 0;
        while (currentIndex < index && movingNode != null)      {           
            movingNode = movingNode.next;
            currentIndex++;
        }

        insertionNode.prev = movingNode.prev;
        movingNode.prev.next = insertionNode;
        insertionNode.next = movingNode;
        movingNode.prev = insertionNode;
        size++;
    }

    public void DeleteAtIndex(int index) {
      if (index < 0 || index >= size)  // ✓ Bounds check
        return;

    var movingNode = head;
    int currentIndex = 0;

    while (currentIndex < index && movingNode != null) {
        movingNode = movingNode.next;
        currentIndex++;
    }

    if (movingNode == null)
        return;

    // Delete head
    if (movingNode == head) {
        head = head.next;
        if (head != null)
            head.prev = null;
        else
            tail = null;
        size--;
        return;
    }

    // Delete tail
    if (movingNode == tail) {
        tail = tail.prev;
        if (tail != null)
            tail.next = null;
        size--;
        return;
    }

    // Delete middle node
    movingNode.prev.next = movingNode.next;
    movingNode.next.prev = movingNode.prev;
    size--;

    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode prev;

    public ListNode(int val = 0, ListNode next = null, ListNode prev = null) {
        this.val = val;
        this.next = next;
        this.prev = prev;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
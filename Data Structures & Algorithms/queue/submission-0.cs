class Deque {
    Node head;
    Node tail;

    public Deque() {
        head = null;
        tail = null;
    }

    public bool isEmpty() {
        var result = false;
        if (head == null && tail == null) {
            result = true;
        }
        return result;
    }

    public void append(int value) {
        var newNode = new Node(value);
        if (tail == null) {
            head = newNode;
            tail = newNode;
        } else {
            tail.next = newNode;
            tail = newNode;
        }
    }

    public void appendleft(int value) {
        var newHeadNode = new Node(value);
        if (head == null) {
            head = newHeadNode;
            tail = newHeadNode;
        } else {
            newHeadNode.next = head;
            head = newHeadNode;
        }
    }

    public int pop() {
        if (tail == null)
            return -1;

        if (head == tail) {
            int value = tail.val;
            head = null;
            tail = null;
            return value;
        }

        var movingNode = head;
        while (movingNode.next != tail) {
            movingNode = movingNode.next;
        }

        var lastValue = tail.val;
        tail = movingNode;
        tail.next = null;
        return lastValue;
    }

    public int popleft() {

        if (tail == null)
            return -1;

        if (head == tail) {
            int value = tail.val;
            head = null;
            tail = null;
            return value;
        }       
       
        var firstValue = head.val;
        head = head.next;        
        return firstValue;


    }
}

public class Node {
    public int val;
    public Node next;
    public Node(int val = 0, Node next = null) {
        this.val = val;
        this.next = next;
    }
}

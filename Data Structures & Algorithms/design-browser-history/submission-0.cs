public class BrowserHistory {
    BrowserNode head;
    BrowserNode tail;
    BrowserNode currentPage;
    
    public BrowserHistory(string homepage) {
        head = new BrowserNode(homepage);
        tail = head;
        currentPage = head;
        
    }
    
    public void Visit(string url) {
        var newNode = new BrowserNode(url);
        currentPage.forward = newNode;
        newNode.back = currentPage;
        currentPage = newNode;
        
    }
    
    public string Back(int steps) {
        int movedBack =  0;
     while (steps > 0 && currentPage.back != null) 
        {
        currentPage = currentPage.back;
        steps--;
        }      
       
        return currentPage.val;
    }
    
    public string Forward(int steps) {
        
        while (steps > 0 && currentPage.forward != null) 
        {
        currentPage = currentPage.forward;
        steps--;
        }      
       
        return currentPage.val;
        
    }
}

public class BrowserNode{
   public string val;
   public BrowserNode forward;
   public BrowserNode back;

    public BrowserNode(string val, BrowserNode forward = null, BrowserNode back = null)
    {
        this.val = val;
        this.forward = forward;
        this.back = back;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */
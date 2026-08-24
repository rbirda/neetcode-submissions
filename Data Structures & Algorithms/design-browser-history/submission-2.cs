/* public class BrowserHistory {
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
} */

public class BrowserHistory {
   
   List<string> visitedUrl ;
   int cur;
   int n ;
    public BrowserHistory(string homepage) {
        visitedUrl = new List<string> { homepage };
        cur = 0;
        n = 1;
    }

     public string Forward(int steps) {
        cur = Math.Min(n - 1, cur + steps);
        return visitedUrl[cur];
     }

     public string Back(int steps) {
         cur = Math.Max(0, cur - steps);
        return visitedUrl[cur];

     }

      public void Visit(string url) {
        cur++;
        if (cur == visitedUrl.Count) {
            visitedUrl.Add(url);
            n++;
        } else {
            visitedUrl[cur] = url;
            n = cur + 1;
        }

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
public class DynamicArray {
      int[] newArr ;
      int capacity = 1 ;
      int length = 0;
    public DynamicArray(int capacity) {
        if (capacity > 0)
        { 
            this.capacity = capacity;
            newArr = new int[capacity];           
        }
    }

    public int Get(int i) {
        if(i > newArr.Length-1)
            return -1;
        
        return newArr[i];

    }

    public void Set(int i, int n) {
        if(i > newArr.Length-1)
            return ;
        
         newArr[i] = n;
    }

    public void PushBack(int n) {      
       if(length == newArr.Length)
       {
         Resize();
       }

       newArr[length] = n;
       length++;
    }

    public int PopBack() {       
       if(length > 0)
       {         
            length--;
       }
     return newArr[length];
    }

    private void Resize() {

        capacity = 2* capacity;
        var updatedArray = new int[capacity];

        for(var i =0 ; i < newArr.Length ; i++)
        {
            updatedArray[i] = newArr[i];
        } 
       newArr = updatedArray;
    }

    public int GetSize() {
      return length;
    }

    public int GetCapacity() {
       int result = -1;
       if(newArr.Length > 0)
       {
         result = newArr.Length;
       }
       return result;
    }
}

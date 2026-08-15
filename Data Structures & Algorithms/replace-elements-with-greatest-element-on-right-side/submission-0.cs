public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var length = arr.Length;       
        int[] ans = new int[length];
       
        for(int i =0; i < length;i++)
        {
           int maxInCurrentInteration = -1;
           for(int j = i+1 ; j < length ;j++)
           { 
               maxInCurrentInteration = Math.Max(arr[j],maxInCurrentInteration);
               
           }          
        ans[i] = maxInCurrentInteration;
        }

        foreach(var num in ans)
        {
            Console.WriteLine(num);
        }

    return ans;
        
    }
}
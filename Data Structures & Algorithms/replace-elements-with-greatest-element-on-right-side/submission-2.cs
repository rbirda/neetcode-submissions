public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var length = arr.Length;       
        int[] ans = new int[length];
        int maxInCurrentInteration = -1;
        for(int i = length -1; i >= 0;i--)
        {
           ans[i] = maxInCurrentInteration;
           maxInCurrentInteration = Math.Max(arr[i],maxInCurrentInteration);
           
        }

        foreach(var num in ans)
        {
            Console.WriteLine(num);
        }

    return ans;
        
    }
}
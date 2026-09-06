public class Solution {
    public int MaxTurbulenceSize(int[] arr) {

        int maxLength = 0;
        int left = 0;      
        if(arr.Length < 2)
          return arr.Length;
        
        for(int right = 1 ; right < arr.Length; right++)
        {
            int cmp = arr[right].CompareTo(arr[right-1]);
            if(cmp == 0)
            {
                left = right;
            }
            else if(right >= 2)
            {
                int prevCmp = arr[right - 1].CompareTo(arr[right - 2]);
            // same direction twice (or prev was equal, already handled) → not a flip
            if (prevCmp == 0 || Math.Sign(cmp) == Math.Sign(prevCmp))
                left = right - 1;

            }

        maxLength = Math.Max(maxLength, right - left + 1);

        }
        
        return maxLength;
    }
}
public class Solution {
    public int MaxArea(int[] heights) {
        var length = heights.Length;
        if (length == 0) {
            return length;
        }

        int maxWater = 0;

        int left = 0;
        int right = length-1;
        int currentMaxWater=0;
        while(left < right)
        {
             currentMaxWater = (right - left) * Math.Min(heights[right], heights[left]);
           maxWater = Math.Max(currentMaxWater,maxWater);
           if(heights[left] < heights[right])
              left++;
            else
              right--;
            

        }

       return maxWater; 
    }
}

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        var length = nums.Length;
        int minLength = length+1;
        if(length == 0)
          return 0;
        int left = 0 ;
        int currentSum = 0;
        for(int right = 0 ; right < length;right++)
        {
            currentSum += nums[right];
            
            while(currentSum >= target)
            {
                minLength = Math.Min(minLength, right-left+1);
                currentSum -= nums[left];
                left++;
            }

        }
     return minLength == length+1 ? 0 : minLength;
        
    }
}
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int consecutiveCount = 0;
        int maxConsecutiveCount = 0;
        int index = 0;
        if (nums.Length == 0)
         return 0;
        while(index < nums.Length)
        {
            if(nums[index] == 1)
            {
                consecutiveCount += 1;
            }
            else
            {
              
               maxConsecutiveCount = Math.Max(maxConsecutiveCount,consecutiveCount);
                
                consecutiveCount = 0;
            }
            index++;
        }
       maxConsecutiveCount = Math.Max(maxConsecutiveCount,consecutiveCount);
        return maxConsecutiveCount;
    }
}
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int currSum = 0;
        int resultArray = nums.Length 
        + 1;
        int left = 0;
        for(var right =0 ; right< nums.Length; right++)
        {
            currSum += nums[right];
            while(currSum >= target)
            {
                resultArray = Math.Min(resultArray, right- left +1);
               currSum -= nums[left];
               left +=1;
            }
            
        }

        return resultArray == nums.Length 
        + 1 ? 0 : resultArray;
    }
}
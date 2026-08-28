public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length == 0)
            return 0;
        int maxSum = nums[0];
        int currSum = 0;
        foreach (var item in nums) {
            currSum = Math.Max(currSum + item, item);
            maxSum = Math.Max((int)currSum, maxSum);
        }

        return maxSum;
    }
}

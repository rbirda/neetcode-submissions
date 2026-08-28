public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        if (nums.Length == 0)
            return 0;
        int maxSum = nums[0];
        int maxending = 0;
        int minending = 0;
        int minSum = 0;
        int totalSum = 0;
        foreach (var item in nums) {
            totalSum += item;

            maxending = Math.Max(maxending + item, item);
            maxSum = Math.Max((int)maxending, maxSum);

            minending = Math.Min(minending + item, item);
            minSum = Math.Min((int)minending, minSum);
        }

        if (maxSum < 0)  // all negative
            return maxSum;

        return Math.Max(maxSum, totalSum - minSum);
    }
}
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int length = nums.Length;

        if (length <= 0) {
            return 0;
        }

        int left = 0;
        int right = 0;
        for (; right < length; right++) {
            if (nums[right] == nums[left]) {
                continue;
            }
            left++;

            nums[left] = nums[right];
        }

        return left+1;
    }
}
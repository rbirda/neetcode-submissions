public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int length = nums.Length;

        if (length <= 0) {
            return 0;
        }

        int left = 0;

        for (int right = 1; right < length; right++) {
            if (nums[right] != nums[left]) {
                left++;
                nums[left] = nums[right];
            }
        }

        return left + 1;
    }
}
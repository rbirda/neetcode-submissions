public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int length = nums.Length;
        int left = 2;

        if (length <= 2)
            return length == 2 ? left : length;

        for (int right = 2; right < length; right++) {
            if (nums[right] != nums[left - 2]) {
                nums[left] = nums[right];
                left++;
            }
        }

        return left;
    }
}
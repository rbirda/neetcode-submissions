public class Solution {
    public int RemoveElement(int[] nums, int val) {
        //int[] expectedNums =  new int[nums.Length];
        int defaultValue = -1;
        int countMatchingValue = 0;
        if(nums.Length == 0)
           return 0;
        
        if(!nums.Contains(val))
            return nums.Length ;

        for(int i=0; i < nums.Length;i++)
        {
            if (nums[i] != val)
            {
                nums[countMatchingValue] = nums[i];
                countMatchingValue++;
            }

        }
        return countMatchingValue;

        
    }
}
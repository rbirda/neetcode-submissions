public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int countMatchingValue = 0;
        var arrayLength = nums.Length;
        if(arrayLength == 0)
           return 0;
        
        if(!nums.Contains(val))
            return arrayLength ;

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
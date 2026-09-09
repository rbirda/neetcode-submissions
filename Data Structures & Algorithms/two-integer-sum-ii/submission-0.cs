public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int length = numbers.Length;
        if(length <=0)
        {
            return new int[0];
        }
        int right = length-1 ;
        int left = 0;
        
        while(left < right)
        {
            if(numbers[left] + numbers[right] > target)
            {
                right--;
            }
            else if(numbers[left] + numbers[right] < target)
            {
                left++;
            }
           else
            {
                return new int[] { left + 1, right + 1 };
            }
        }

        return new int[0];
        
    }
}

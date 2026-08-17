public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = default ;
       if(nums.Length <=0)
          return ans;

        ans = new int[2 * nums.Length];

        for(var i =0 ; i< nums.Length ; i++)
        {
            ans[i] = ans[nums.Length + i] = nums[i];
            
        }
      
        return ans;
    }
}
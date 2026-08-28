public class Solution {
    public int MaxProduct(int[] nums) {

        int maxProduct = nums[0];
        int currentMax = 1;
        int currentMin = 1;
      
      foreach(var num in nums)
      {
        int previousMax = currentMax;
        int previousMin = currentMin;
        currentMax = Math.Max(num, Math.Max(previousMax * num, previousMin * num));
        currentMin = Math.Min(num, Math.Min(previousMax * num, previousMin * num));
        maxProduct =  Math.Max(maxProduct, currentMax);

      }
       

        return maxProduct;
        
    }
}

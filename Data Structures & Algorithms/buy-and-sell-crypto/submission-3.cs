public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++) {

       if(maxProfit < prices[i]- minPrice)
 maxProfit = prices[i]- minPrice;
           
            if(prices[i] < minPrice)
            {
           
              minPrice = prices[i];
            }
        }

        return maxProfit;
    }
}

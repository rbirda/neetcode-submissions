public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int resultSubarrays = 0;
        int currentWindowSum = 0;
        int targetSum = k * threshold;
        if (arr.Length == 0)
            return resultSubarrays;

        var window = new List<int>();
        for (int i = 0; i < arr.Length; i++) {

            currentWindowSum +=  arr[i];
            if(i>= k-1)
            {
                 if (currentWindowSum >= targetSum)
                {
                    resultSubarrays++;
                }

                // Remove the leftmost element before sliding
                currentWindowSum -= arr[i - k + 1];

            }
         
        }

        return resultSubarrays;
    }
}
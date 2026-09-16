public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var isDuplicateValuePresent = false;
        if(nums.Length <= 0)
        {
            return isDuplicateValuePresent;
        }

        HashSet<int> window = new HashSet<int>();

        for(var i = 0 ; i< nums.Length; i++)
        {
            if(window.Contains(nums[i]))
              isDuplicateValuePresent = true;
            
            window.Add(nums[i]);
            if(window.Count > k)
            {
                window.Remove(nums[i-k]);
            }
        }

        return isDuplicateValuePresent;
        
    }
}
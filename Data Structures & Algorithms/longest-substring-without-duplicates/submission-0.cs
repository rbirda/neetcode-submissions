public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxArrayLength = 0;
        int left = 0;
        if (string.IsNullOrEmpty(s))
            return maxArrayLength;
        var resulthashSet = new HashSet<char>();
        for (int right = 0; right < s.Length; right++) {
                    while(resulthashSet.Contains(s[right]))
            {
                resulthashSet.Remove(s[left]);
                left +=1;
            }

            resulthashSet.Add(s[right]);
             maxArrayLength = Math.Max(maxArrayLength, resulthashSet.Count);

        }

        return maxArrayLength;
    }
}

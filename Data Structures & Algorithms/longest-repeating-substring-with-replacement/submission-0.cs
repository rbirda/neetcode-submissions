public class Solution {
    public int CharacterReplacement(string s, int k) {
        int longestSubstring = 0;
        int left = 0;
        int maxFrequency = 0;
        if (string.IsNullOrEmpty(s))
            return longestSubstring;
        var dict = new Dictionary<char, int>();

        for (int right = 0; right < s.Length; right++) {
            char current = s[right];
            if (dict.Keys.Contains(current))
                dict[current] = dict[s[right]] + 1;
            else {
                dict.Add(current, 1);
            }
            maxFrequency = Math.Max(maxFrequency, dict[current]);
            int windowLength = right - left + 1;
            int replacementsNeeded = windowLength - maxFrequency;

            while (replacementsNeeded > k) {
                char leftChar = s[left];
                dict[leftChar]--;
                left++;

                windowLength = right - left + 1;
                replacementsNeeded = windowLength - maxFrequency;
            }

            longestSubstring = Math.Max(longestSubstring, right - left + 1);
        }

        return longestSubstring;
    }
}

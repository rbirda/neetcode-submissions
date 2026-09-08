public class Solution {
    public bool IsPalindrome(string s) {

        bool result = false;
        
        if(string.IsNullOrEmpty(s))
        {
            return result;
        }
          StringBuilder filtered = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                filtered.Append(char.ToLower(c));
            }
        }
        string cleaned = filtered.ToString();
        int left = 0;
        int right = cleaned.Length - 1;
         while(left < right)
         {
            if(cleaned[left] != cleaned[right])
            {
                return result;
            }
            left++;
            right--;
         }
        result = true;
        return result;
    }
}

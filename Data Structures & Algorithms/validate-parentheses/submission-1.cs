public class Solution {
    public bool IsValid(string s) {
        if(String.IsNullOrEmpty(s))
        {
            return false;
        }

        Char[] characters = s.ToCharArray();
        Stack<char> brackets = new Stack<char>();
        foreach( var item in characters)
        {
           if (item == '(' || item == '{' || item == '[')       {
                brackets.Push(item);
           }
            else {
                // Check if stack is empty or top doesn't match
                if (brackets.Count == 0) 
                    return false;
                     char top = brackets.Pop();
                
                // Verify the closing bracket matches the opening bracket
                if ((item == ')' && top != '(') ||
                    (item == '}' && top != '{') ||
                    (item == ']' && top != '[')) {
                    return false;
            }
            }
        }

        return !brackets.Any();

    }
}

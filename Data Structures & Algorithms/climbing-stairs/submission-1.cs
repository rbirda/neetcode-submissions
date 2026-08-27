public class Solution {
     public int ClimbStairs(int n) {

    if (n <= 2) return n;

    int prev1 = 1;
    int prev2 = 2;

    for (int i = 3; i <= n; i++)
    {
        int current = prev1 + prev2;
        prev1 = prev2;
        prev2 = current;
    }

    return prev2;
  



//     public int ClimbStairs(int n) {
//         return Dfs(n, 0);
//     }
//     public int Dfs(int n, int i) {
//         if (i >= n)
//             return i == n ? 1 : 0;
//         return Dfs(n, i + 1) + Dfs(n, i + 2);
    }
 }

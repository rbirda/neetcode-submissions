public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        int maxLength = 0;
        int left = 0;

        if (arr.Length < 2)
            return arr.Length;;

        for (int right = 1; right < arr.Length; right++) {
            int currentCmp = arr[right].CompareTo(arr[right - 1]);
            if(currentCmp == 0)
            {
                left = right;
            }

            else if(right >=2)
            {
                int prevCmp = arr[right-1].CompareTo(arr[right-2]);

                if(prevCmp == 0 || Math.Sign(currentCmp) == Math.Sign(prevCmp))
                {
                    left = right-1;
                }

            }

            maxLength = Math.Max(maxLength, right- left +1);
        }

        return maxLength;
    }
}
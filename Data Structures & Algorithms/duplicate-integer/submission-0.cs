public class Solution { 
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> numsCount= new Dictionary<int,int>();
        
        bool result = false;
        foreach(var num in nums)
        { 
            int currentNumCount =  0;
            //Console.WriteLine(num.ToString());
            if(numsCount.ContainsKey(num))
            {
                currentNumCount =numsCount[num] + 1;
                numsCount[num] = currentNumCount;
            }
            else
            {
                currentNumCount +=1;
                numsCount.Add(num,currentNumCount);
            }
            if (numsCount[num] > 1)
            {
                    result = true;
                    break;
            }
            

        }
        return result;
    }
}
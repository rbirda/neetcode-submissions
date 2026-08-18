public class Solution {
    public int CalPoints(string[] operations) {
      if(operations.Length <=0)
          return -1;

       int sum = 0;
       List<int> result = new List<int>();

       foreach(var operation in operations)
       {
          if(int.TryParse(operation, out int number))
          {
                result.Add(number);
                sum += number;
          }
          if(operation == "+")
          {
            var addedNumber = result[result.Count -1] + result[result.Count - 2];
            //result.RemoveAt(result.Count-1);
            //result.RemoveAt(result.Count-2);
            result.Add(addedNumber);
            sum += addedNumber;
          }
          if(operation == "D")
          {
            var doubleScore =  2 * result[result.Count - 1];
            //result.RemoveAt(result.Count-1);
            result.Add(doubleScore);
            sum += doubleScore;
          }
          if(operation == "C")
          {
            sum -= result[result.Count - 1];  
            result.RemoveAt(result.Count-1);
                      
          }
       }
    return sum;

    }
}

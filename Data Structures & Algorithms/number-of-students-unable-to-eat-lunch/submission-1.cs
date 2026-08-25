public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Stack<int> sandwichStack = new Stack<int>();
        for (int i = sandwiches.Length - 1; i >= 0; i--)    {
            sandwichStack.Push(sandwiches[i]);
        }
        Queue<int> studentQueue = new Queue<int>(students);
        var sandwichesLength = sandwichStack.Count;
        var studentLength = studentQueue.Count;

        while (studentQueue.Count > 0 && studentQueue.Contains(sandwichStack.Peek())) {
            if (studentQueue.Peek() == sandwichStack.Peek()) {
                studentQueue.Dequeue();
                sandwichStack.Pop();
            } else {
                studentQueue.Enqueue(studentQueue.Dequeue());
            }
        }

        return studentQueue.Count;
    }
}
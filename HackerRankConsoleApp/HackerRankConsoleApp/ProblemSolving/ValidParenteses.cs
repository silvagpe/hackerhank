namespace HackerRankConsoleApp.ProblemSolving
{
    public class ValidParenteses
    {
        public void Start()
        {
            Console.WriteLine(IsValid("()"));        // Output: True
            Console.WriteLine(IsValid("()[]{}"));    // Output: True
            Console.WriteLine(IsValid("(]"));        // Output: False
            Console.WriteLine(IsValid("([)]"));      // Output: False
            Console.WriteLine(IsValid("{[]}"));      // Output: True
        }

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' && stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack.Count > 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Count > 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    return false; // Invalid character or mismatch
                }
            }

            return stack.Count == 0;
        }


        public static void OrderDescArray(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(",", arr));
        }
    }
}

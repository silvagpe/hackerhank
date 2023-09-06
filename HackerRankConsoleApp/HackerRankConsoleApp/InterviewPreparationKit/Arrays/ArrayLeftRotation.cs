namespace HackerRankConsoleApp.InterviewPreparationKit.Arrays
{
    internal class ArrayLeftRotation
    {
        public void Start()
        {
            var arr = new List<int>
            {
                1,2,3,4,5
            };

            var result = rotLeft(arr, 4);


            Console.WriteLine($"Test 1: Numeber 4");
            Console.WriteLine($"Array: 1 2 3 4 5");
            Console.WriteLine($"Expected = 5 1 2 3 4 : Result {string.Join(" ", result)}");

        }

        public static List<int> rotLeft(List<int> a, int d)
        {
            Queue<int> queue = new Queue<int>(a.AsEnumerable());

            for (int i = 0; i < d; i++)
            {
                int temp = queue.Dequeue();
                queue.Enqueue(temp);
            }

            return queue.ToList();
        }
    }
}

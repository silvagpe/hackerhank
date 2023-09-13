namespace HackerRankConsoleApp.InterviewPreparationKit.Arrays
{
    internal class MinimumSwaps2
    {
        public void Start()
        {
            var arr = new List<int>
            {
                2,3,4,1,5
            };

            var result = minimumSwaps(arr.ToArray());


            Console.WriteLine($"Test 1: Numeber 4");
            Console.WriteLine($"Array: 1 2 3 4 5");
            Console.WriteLine($"Expected = 5 1 2 3 4 : Result {string.Join(" ", result)}");

        }

        private int minimumSwaps(int[] arr)
        {
            int swaps = 0;

            return 0;
        }
    }
}

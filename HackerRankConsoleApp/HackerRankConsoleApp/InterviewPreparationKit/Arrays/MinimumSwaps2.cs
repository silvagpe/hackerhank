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

            Console.WriteLine($"Test:");
            Console.WriteLine($"Array: {string.Join(',', arr)}");
            Console.WriteLine($"Expected = 3 : Result {result}");

        }

        private int minimumSwaps(int[] arr)
        {
            int swaps = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - 1 == i)
                {
                    continue;
                }

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] - 1 == i)
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                        swaps++;
                        break;
                    }
                }
            }

            return swaps;
        }
    }
}

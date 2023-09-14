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

            var indexMap = new List<int>(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                int expected = i + 1;

                if (current != expected)
                {
                    int currentIndex = indexMap.IndexOf(expected);

                    arr[i] = arr[currentIndex];
                    arr[currentIndex] = current;

                    indexMap[i] = arr[i];
                    indexMap[currentIndex] = current;

                    swaps++;

                }
            }

            Console.WriteLine(string.Join(',', indexMap.ToArray()));
            Console.WriteLine(string.Join(',', arr));
            return swaps;
        }

        private int minimumSwaps_2(int[] arr)
        {
            int swaps = 0;

            var indexMap = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                indexMap[arr[i]] = i;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                int expected = i + 1;

                if (current != expected)
                {
                    int currentIndex = indexMap[expected];

                    arr[i] = arr[currentIndex];
                    arr[currentIndex] = current;

                    indexMap[current] = currentIndex;
                    indexMap[expected] = i;

                    swaps++;

                }
            }

            Console.WriteLine(string.Join(',', indexMap.ToArray()));
            Console.WriteLine(string.Join(',', arr));
            return swaps;
        }

        private int minimumSwaps_v1(int[] arr)
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

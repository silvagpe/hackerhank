namespace HackerRankConsoleApp.InterviewPreparationKit.Arrays
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/2d-array/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    /// </summary>
    internal class Test2dArray
    {
        public void Start()
        {
            List<List<int>> arr = new List<List<int>>
            {
                new List<int>() { 1,1,1,0,0,0 },
                new List<int>() { 0,1,0,0,0,0 },
                new List<int>() { 1,1,1,0,0,0 },
                new List<int>() { 0,0,2,4,4,0 },
                new List<int>() { 0,0,0,2,0,0 },
                new List<int>() { 0,0,1,2,4,0 },

            };

            var result = hourglassSum(arr);


            Console.WriteLine($"Test 1");
            Console.WriteLine($"-----------");
            Console.WriteLine(@"1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0");
            Console.WriteLine($"-----------");
            Console.WriteLine($"Expected = 19 : Result {result}");


            arr = new List<List<int>>
            {
                new List<int>() { -1,-1,0,-9,-2,-2 },
                new List<int>() { -2,-1,-6,-8,-2,-5 },
                new List<int>() { -1,-1,-1,-2,-3,-4 },
                new List<int>() { -1,-9,-2,-4,-4,-5 },
                new List<int>() { -7,-3,-3,-2,-9,-9 },
                new List<int>() { -1,-3,-1,-2,-4,-5 },
            };

            result = hourglassSum(arr);

            Console.WriteLine($"Test 2");
            Console.WriteLine($"-----------");
            Console.WriteLine(@"-1 -1 0 -9 -2 -2
-2 -1 -6 -8 -2 -5
-1 -1 -1 -2 -3 -4
-1 -9 -2 -4 -4 -5
-7 -3 -3 -2 -9 -9
-1 -3 -1 -2 -4 -5");
            Console.WriteLine($"-----------");
            Console.WriteLine($"Expected = 19 : Result {result}");
        }

        public static int hourglassSum(List<List<int>> arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Count - 2; i++)
            {
                for (int j = 0; j < arr.Count - 2; j++)
                {
                    var total = sum(arr, i, j);
                    max = Math.Max(max, total);
                }
            }
            Console.WriteLine($"Max: {max}");
            return max;
        }

        private static int sum(List<List<int>> arr, int i, int j)
        {

            return arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                + arr[i + 1][j + 1]
                + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
        }
    }
}

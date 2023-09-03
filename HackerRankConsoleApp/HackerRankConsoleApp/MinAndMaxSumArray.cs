namespace HackerRankConsoleApp
{
    public class MinAndMaxSumArray
    {
        public void Start()
        {
            List<int> arr = new List<int>
            {
                140638725, 436257910, 953274816, 734065819, 362748590
            };

            miniMaxSum(arr);
        }

        public static void miniMaxSum(List<int> arr)
        {

            long min = arr[0];
            long max = arr[0];
            long sum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }

                sum += arr[i];
            }

            long sumMin = sum - max;
            long sumMax = sum - min;
            Console.WriteLine($"{sumMin} {sumMax}");
        }
    }
}


//140638725 
//362748590
//436257910 
//734065819
//953274816
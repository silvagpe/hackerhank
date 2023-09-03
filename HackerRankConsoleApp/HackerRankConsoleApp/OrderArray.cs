namespace HackerRankConsoleApp
{
    public class OrderArray
    {
        public void Start()
        {
            List<int> arr = new List<int>
            {
                8, 1, 3, 7, 6, 5, 4, 3,
            };

            Console.WriteLine("Array asc");
            OrderAscArray(arr);

            Console.WriteLine("Array decrecents");
            OrderDescArray(arr);
        }

        public static void OrderAscArray(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(",", arr));
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


//140638725 
//362748590
//436257910 
//734065819
//953274816
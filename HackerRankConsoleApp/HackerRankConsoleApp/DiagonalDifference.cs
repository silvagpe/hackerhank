namespace HackerRankConsoleApp
{
    public class DiagonalDifference
    {

        public void Start()
        {
            List<List<int>> arr = new List<List<int>>
            {
                new List<int>() { 11, 2, 4 },
                new List<int>() { 4, 5, 6 },
                new List<int>() { 10, 8, -12 }
            };

            var result = diagonalDifference(arr);

            Console.WriteLine(result);
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            List<int> d1 = new List<int>();
            List<int> d2 = new List<int>();

            var pos1 = 0;
            var pos2 = arr.Count() - 1;
            for (int i = 0; i < arr.Count(); i++)
            {

                for (int j = 0; j < arr.Count(); j++)
                {

                    if (i == pos1 && j == pos1)
                    {
                        d1.Add(arr[i][j]);
                    }
                    if (i == pos1 && j == pos2)
                    {
                        d2.Add(arr[i][j]);
                    }
                }

                pos1++;
                pos2--;
            }

            return Math.Abs(d1.Sum() - d2.Sum());
        }
    }
}

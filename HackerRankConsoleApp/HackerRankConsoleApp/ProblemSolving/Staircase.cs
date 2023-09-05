namespace HackerRankConsoleApp.ProblemSolving
{
    public class Staircase
    {
        public void Start()
        {
            Console.WriteLine("-------------------------");
            staircase(6);
        }

        public static void staircase(int n)
        {
            var arr = new List<List<string>>();

            int limit = n - 1;

            for (int i = 0; i < n; i++)
            {

                var row = new List<string>();
                for (int j = 0; j < n; j++)
                {
                    if (j >= limit)
                    {
                        row.Add("#");
                    }
                    else
                        row.Add(" ");

                }

                limit--;
                arr.Add(row);
            }

            arr.ForEach(x => Console.WriteLine(string.Join("", x)));
        }
    }
}

namespace HackerRankConsoleApp.InterviewPreparationKit.WarmUpChallenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/repeated-string/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup&h_r=next-challenge&h_v=zen
    /// </summary>
    internal class RepeatedString
    {
        public void Start()
        {
            var result = repeatedString("aba", 3);
            Console.WriteLine($"Test 1: 'aba', 3 - Expected =  2: Result {result}");

            result = repeatedString("aba", 10);
            Console.WriteLine($"Test 2: 'aba', 10 - Expected = 7 : Result {result}");

            result = repeatedString("a", 1_000_000_000_000);
            Console.WriteLine($"Test 1: 'a', 1_000_000_000_000 - Expected =  1000000000000: Result {result}");
        }


        public static long repeatedString(string s, long n)
        {
            long countInString = s.Where(x => x.Equals('a')).Count();
            long repeartCount = n / s.Length;
            long totalCount = repeartCount * countInString;
            long remainingCharacteres = n % s.Length;

            for (int i = 0; i < remainingCharacteres; i++)
            {
                if (s[i] == 'a')
                {
                    totalCount++;
                }
            }

            return totalCount;
        }
    }
}

namespace HackerRankConsoleApp.InterviewPreparationKit.WarmUpChallenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    /// </summary>
    public class JumpingOnTheClouds
    {
        public void Start()
        {
            var result = jumpingOnClouds(new List<int> { 0, 0, 1, 0, 0, 1, 0 });
            Console.WriteLine($"Test 1 Expected = 4 : Result {result}");

            result = jumpingOnClouds(new List<int> { 0, 0, 0, 0, 1, 0 });
            Console.WriteLine($"Test 2 Expected = 3 : Result {result}");
        }

        public static int jumpingOnClouds(List<int> c)
        {
            int jumps = 0;

            int i = 0;
            while (i < c.Count)
            {

                if (i + 2 < c.Count && c[i + 2] != 1)
                {
                    jumps++;
                    i = i + 2;
                }
                else if (i + 1 < c.Count && c[i + 1] != 1)
                {
                    jumps++;
                    i = i + 1;
                }
                else
                {
                    i++;
                }
            }

            return jumps;
        }
    }
}

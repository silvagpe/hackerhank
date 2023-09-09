namespace HackerRankConsoleApp.InterviewPreparationKit.Arrays
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/new-year-chaos/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    /// </summary>
    internal class NewYearChaos
    {
        private static int memTests = -1;
        private static int numOfPeople = 0;
        private static List<string> Results = new List<string>();

        public void Start()
        {

            var tests = new List<List<int>>
            {
                new List<int>() { 2 },
                //new List<int>() { 1,2,5,3,4,7,8,6 }
                //new List<int>() { 1,2,5,3,7,8,6,4 }
                new List<int>() { 8 },
                new List<int>() { 5,1,2,3,7,8,6,4 },
                new List<int>() { 8 },
                new List<int>() { 1,2,5,3,7,8,6,4 }
            };

            foreach (var test in tests)
            {
                minimumBribes(test);
            }
        }

        public static void minimumBribes(List<int> q)
        {
            int bribes = 0;
            bool chaotic = false;

            for (int i = q.Count - 1; i >= 0; i--)
            {
                int originalPosition = q[i] - 1;
                int currentPosition = i;

                if (originalPosition - currentPosition > 2)
                {
                    chaotic = true;
                    break;
                }
            }

            if (chaotic)
            {
                Results.Add("Too chaotic");
            }
            else
            {
                Results.Add(bribes.ToString());
            }

        }



        private static void MinimumBribes2(List<int> q)
        {
            int bribes = 0;
            bool chaotic = false;

            for (int i = q.Count - 1; i >= 0; i--)
            {
                int originalPosition = q[i] - 1; // Convert to 0-based index
                int currentPosition = i;

                if (originalPosition - currentPosition > 2)
                {
                    chaotic = true;
                    break;
                }

                for (int j = Math.Max(0, originalPosition - 1); j < currentPosition; j++)
                {
                    if (q[j] > q[i])
                    {
                        bribes++;
                    }
                }
            }

            if (chaotic)
            {
                Results.Add("Too chaotic");
            }
            else
            {
                Results.Add(bribes.ToString());
            }
        }

    }
}

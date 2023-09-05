namespace HackerRankConsoleApp.InterviewPreparationKit.WarmUpChallenges;

/// <summary>
/// https://www.hackerrank.com/challenges/counting-valleys/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup&h_r=next-challenge&h_v=zen
/// </summary>
public class CountingValleys
{
    public void Start()
    {
        int steps = 12;
        string path = "DDUUDDUDUUUD";

        var result = countingValleys(steps, path);

        Console.WriteLine($"Expected = 2 : Result {result}");
    }

    public static int countingValleys(int steps, string path)
    {
        int seaLevel = 0; // Start at sea level
        int valleyCount = 0;

        foreach (char step in path)
        {
            if (step == 'U')
            {
                seaLevel++;
                if (seaLevel == 0)
                {
                    valleyCount++;
                }

            }
            else if (step == 'D')
            {
                seaLevel--;
            }
        }

        return valleyCount;
    }
}
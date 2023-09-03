namespace HackerRankConsoleApp.ProblemSolving
{
    public class TimeConversion
    {
        public void Start()
        {

            Console.WriteLine("Array asc");
            timeConversion("07:05:45PM");

        }

        public static void timeConversion(string s)
        {
            string ampm = s.Substring(s.Length - 2, 2);
            s = s.Replace(ampm, "");

            DateTime dt = DateTime.Parse($"{s} {ampm}");
            Console.WriteLine(dt.ToString("HH:mm:ss"));
        }
    }
}

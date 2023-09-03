namespace HackerRankConsoleApp
{
    public class PlusAndMinusCalcRatio
    {
        public void Start()
        {
            List<int> arr = new List<int>
            {
                -4, 3, -9, 0, 4, 1
            };

            plusMinus(arr);
        }

        private static string calcRation(decimal v1, decimal v2)
        {
            decimal calc = v1 / v2;
            return calc.ToString("0.000000");
        }

        public static void plusMinus(List<int> arr)
        {
            var pos = new List<int>();
            var zeros = new List<int>();
            var neg = new List<int>();

            foreach (var v in arr)
            {
                if (v > 0)
                {
                    pos.Add(v);
                }
                else if (v == 0)
                {
                    zeros.Add(v);
                }
                else
                {
                    neg.Add(v);
                }
            }

            Console.WriteLine(calcRation(pos.Count, arr.Count));
            Console.WriteLine(calcRation(neg.Count, arr.Count));
            Console.WriteLine(calcRation(zeros.Count, arr.Count));
        }
    }
}

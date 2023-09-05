namespace HackerRankConsoleApp.InterviewPreparationKit;

public class SockMerchant
{
    public void Start()
    {
        List<int> arr = new List<int>
            {
                10,20,20,10,10,30,50,10,20
            };

        sockMerchant(9, arr);
    }

    public static void sockMerchant(int n, List<int> arr)
    {
        var list = new List<int>();
        int pairs = 0;

        for (int i = 0; i < n; i++)
        {
            if (list.IndexOf(arr[i]) == -1){
                list.Add(arr[i]);
            }
            else{
                pairs++;
                list.RemoveAt(list.IndexOf(arr[i]));  
            }
        }
        
        Console.WriteLine($"Pairs: {pairs}");
    }
}
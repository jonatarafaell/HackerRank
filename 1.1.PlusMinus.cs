
class PlusMinus
{
    public static void plusMinus(List<int> arr)
    {
        decimal arrayCount = decimal.Parse(arr.Count.ToString());

        int positives = 0;
        int negatives = 0;
        int zeros = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                positives++;
                continue;
            }

            if (arr[i] < 0)
            {
                negatives++;
                continue;
            }

            zeros++;
        }

        Console.WriteLine((positives / arrayCount).ToString("N6"));
        Console.WriteLine((negatives / arrayCount).ToString("N6"));
        Console.WriteLine((zeros / arrayCount).ToString("N6"));
    }
}

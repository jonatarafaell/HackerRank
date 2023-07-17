class MiniMaxSum
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();

        Int64 min = 0;
        Int64 max = 0;
        int count = 0;

        while (count < 4)
        {
            min += arr[count];
            max += arr[count + 1];
            count++;
        }

        Console.Write(min + " " + max);
    }
}
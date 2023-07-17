
namespace HackerRank
{
    public class MockTest1
    {
        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            int median = arr[(arr.Count - 1) / 2];
            return median;
        }
    }
}

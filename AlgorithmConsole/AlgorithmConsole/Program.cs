
namespace AlgorithmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.StartUp();
            SelectionSort selectionSort = new SelectionSort();
            //selectionSort.StartUp();
            InsertionSort insertionSort = new InsertionSort();
            //insertionSort.StartUp();
            LeetCode leetCode = new LeetCode();
            //leetCode.RemoveDuplicates(new int[] {1,1,2,2,3,3 });
            InfoSysInterviewQ1 infoSysInterviewQ1 = new InfoSysInterviewQ1();
            //infoSysInterviewQ1.StartUp();
            InfoSysInterviewQ2 infoSysInterviewQ2 = new InfoSysInterviewQ2();
            // infoSysInterviewQ2.StartUp();
            leetCode.MaxProfit(new int[] { 1,2,3,4,5});
        }
    }
}

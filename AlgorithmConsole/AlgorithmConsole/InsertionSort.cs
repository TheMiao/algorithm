using System;
using System.Diagnostics;


namespace AlgorithmConsole
{
    public class InsertionSort
    {
        public void StartUp()
        {
            int[] arr = { 15, 0, 10, 50, 55, 35, 15, 20 }; //待排序数组
            InsertionSort1(arr);
        }

        public void InsertionSort1(int[] intList)
        {
            var watch = new Stopwatch();
            watch.Start();
            var temp = 0;
            for (int i = 0; i < intList.Length; i++)
            {
                temp = intList[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (intList[j] > temp)
                    {
                        intList[j + 1] = intList[j];
                        if (j == 0)
                        {
                            intList[0] = temp;
                        }
                    }
                    else
                    {
                        intList[j + 1] = temp;
                        break;
                    }
                }
            }
            watch.Stop();
            var printOut = string.Empty;
            foreach (var item in intList)
            {
                printOut += " " + item;
            }
            Console.WriteLine($"Result 1: {printOut}");
            Console.WriteLine($"Response time {watch.Elapsed.TotalMilliseconds.ToString()}ms");
            Console.ReadLine();
        }
    }
}

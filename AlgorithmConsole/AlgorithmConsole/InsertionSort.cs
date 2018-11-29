using System;
using System.Diagnostics;


namespace AlgorithmConsole
{
    public class InsertionSort
    {
        public void StartUp()
        {
            int[] arr = { 15, 0, 10, 50, 55, 35, 16, 20 }; //待排序数组
            InsertionSort1(arr);
        }

        public void InsertionSort1(int[] intList)
        {
            var watch = new Stopwatch();
            watch.Start();
            var temp = 0;
            for (int i = 0; i < intList.Length; i++)
            {
                temp = intList[i]; // 设定当前循环值为temp
                for (int j = i - 1; j >= 0; j--)   // 反向循环
                {
                    if (intList[j] > temp) // 如果当前值大于 temp值
                    {
                        intList[j + 1] = intList[j]; // 交换两个位置的值
                        if (j == 0) // 如果循环到头
                        {
                            intList[0] = temp; // 首个值为最小值
                        }
                    }
                    else // 如果当前值小于temp值
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

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

        private void InsertionSort1(int[] intList)
        {
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < intList.Length; i++)
            {
                var min = intList[i]; // 设定当前循环值为temp
                for (int j = i - 1; j >= 0; j--)   // 反向循环
                {
                    if (intList[j] > min) // 如果当前值大于 temp值
                    {
                        intList[j + 1] = intList[j]; // 赋J的值给J+1
                        if (j == 0) // 如果循环到头
                        {
                            intList[0] = min; // 交换min的值
                        }
                    }
                    else // 执行如果数组当中j的值比所比较的值小,则赋min值给j+1(j+1是比j大的值)
                    {
                        intList[j + 1] = min;
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

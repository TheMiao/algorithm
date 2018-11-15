using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intList = new int[] { -1, 2, 6, 4, 5, 3, 7, 8, 11, 14 };
            //BubbleSort1(intList);
            BubbleSort2(intList);
            Console.ReadLine();
        }

        static void BubbleSort1(int[] intList)
        {
            var watch = new Stopwatch();
            watch.Start();
            var count = 0;
            for (int i = 0; i < intList.Length; i++)
            {
                for (int j = 0; j < intList.Length - 1 - i; j++)
                {
                    if (intList[j] > intList[j + 1]) // 相邻元素两两对比
                    {
                        var temp = intList[j + 1]; // 元素交换
                        intList[j + 1] = intList[j];
                        intList[j] = temp;
                    }
                    count++; // 计算次数
                }
            }
            watch.Stop();
            var printOut = string.Empty;
            foreach (var item in intList)
            {
                printOut += " " + item;
            }
            Console.WriteLine($"Result 1: {printOut}");
            Console.WriteLine($"Count time: {count}");
            Console.WriteLine($"Response time {watch.Elapsed.TotalMilliseconds.ToString()}ms");
        }

        static void BubbleSort2(int[] intList)
        {
            var watch = new Stopwatch();
            watch.Start();
            int i = intList.Length - 1;
            int count = 0; // 计数
            while (i > 1)
            {
                int lastChange = 1; // 记录最后一次交换位置
                for (int j = 1; j < i; j++)
                {
                    // 前面比后面大，则进行交换
                    if (intList[j] > intList[j + 1])
                    {
                        intList[j] = intList[j] + intList[j + 1];
                        intList[j + 1] = intList[j] - intList[j + 1];
                        intList[j] = intList[j] - intList[j + 1];
                        lastChange = j; // 每交换一次更新一次
                    }
                    count++;
                }
                i = lastChange;
            }
            watch.Stop();
            var printOut = string.Empty;
            foreach (var item in intList)
            {
                printOut += " " + item;
            }
            Console.WriteLine($"Result 1: {printOut}");
            Console.WriteLine($"Count time: {count}");
            Console.WriteLine($"Response time {watch.Elapsed.TotalMilliseconds.ToString()}ms");
        }
    }
}

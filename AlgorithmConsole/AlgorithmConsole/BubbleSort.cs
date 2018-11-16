using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    public class BubbleSort
    {
        public void StartUp()
        {
            int[] intList = new int[] { 2, -2, 6, 4, 5, 3, 7, 8, 11, 14 };
            BubbleSort1(intList);
            BubbleSort2(intList);
            Console.ReadLine();

        }

        public void BubbleSort1(int[] intList)
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

        /*
         * 这里我们根据算法一中的思路进行下优化，我们注意到上述arr数组中后四个数7,8,11,14是已排好序的，我们遍历比较一次就已经没有必要再去比较了。
         * 因此，在排序过程中，我们可能会重复的去多次比较已排好的序列，这样就造成了冗余，当数据量大时，会明显的耗时。
         * 为解决这个问题，我们在这里添加一个lastIndex索引，用于标记最后一次交换的位置（注意，这里是交换不是比较），
         * 当交换到arr数组中7之前，也就是下标为4的时候，不再交换，说明后面的已经有序，下次就直接比较到下标为4的位置，后面的不再比较。 
         * 另外，如果是倒序排正序，则没有优化，比较n*(n-1)/2次。
         */
        public void BubbleSort2(int[] intList)
        {

            var watch = new Stopwatch();
            watch.Start();
            int i = intList.Length - 1;
            int count = 0; // 计数
            while (i > 1)
            {
                int lastChange = 1; // 记录最后一次交换位置
                for (int j = 0; j < i; j++)
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

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    public class SelectionSort
    {
        public void StartUp()
        {
            int[] arr = { 15, 0, 10, 50, 55, 35, 15, 20 }; //待排序数组
            SelectionSort1(arr);
        }
        private void SelectionSort1(int[] intList)
        {
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < intList.Length; i++)
            {
                var minVal = intList[i]; // 假设 i 下表就是最小的数
                var minIndex = i; //记录我认为最小数的下标

                for (int j = i + 1; j < intList.Length; j++) // 这里只是找出这一趟最小的数值 ,并记录下它的下标
                {
                    //说明我们认为的最小值, 不是最小
                    if (minVal > intList[j]) // 这里大于号是升序(大于是找出最小值) 小于是降序(小于是找出最大值)
                    {
                        minVal = intList[j]; //更新这趟最小值(最大值)的值,
                        minIndex = j; // 记录下标
                    }
                }

                // 最后把最小的数和第一个位置交换
                var temp = intList[i]; //把第一个原先认为是最小值的数, 临时保存起来
                intList[i] = intList[minIndex]; //把最终我们找到的最小值赋给这一趟的比较的第一个位置
                intList[minIndex] = temp; //把原先保存好临时数值放回这个数组的空地方, 保证数组的完整性.
            }
            watch.Stop();
            var displayString = string.Empty;
            foreach (var item in intList)
            {
                displayString += " " + item;
            }
            Console.WriteLine($"Result 1: {displayString}");
            Console.WriteLine($"Response time {watch.Elapsed.TotalMilliseconds.ToString()}ms");
            Console.ReadLine();
        }
    }
}

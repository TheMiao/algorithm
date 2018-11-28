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
                var min = intList[i];
                int minIndex = i;
                for (int j = i+1; j < intList.Length; j++) //遍历所有数组的数
                {
                    if (min > intList[j]) //如果此轮选择的值大于正在遍历值
                    {
                        min = intList[j]; //选择正在遍历的值为最小值
                        minIndex = j; //记录下标
                    }
                }
                
                //结束第一轮的遍历, 开始i和找到最小的数位置!
                if (minIndex != i) // 如果找到比当前目标更小的最小值
                {
                    intList[minIndex] = intList[i]; //交换所得到的最小值到当前遍历的位置
                    
                    intList[i] = min; //交换大值到数列中最后选中的最小值当中
                }
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

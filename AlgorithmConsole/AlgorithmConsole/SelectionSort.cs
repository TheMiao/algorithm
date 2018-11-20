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
                for (int j = i+1; j < intList.Length; j++)
                {
                    if (min > intList[j])
                    {
                        min = intList[j];
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    intList[minIndex] = intList[i];
                    intList[i] = min;
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

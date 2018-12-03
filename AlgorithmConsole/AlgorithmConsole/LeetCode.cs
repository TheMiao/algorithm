using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    public class LeetCode
    {
        private int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target - nums[j] == nums[i])
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

        public void RemoveDuplicates(int[] intArray)
        {
            var intList = intArray.ToList();
            for (int i = 0; i < intArray.Length; i++)
            {
                var currentValue = intArray[i];
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (currentValue == intArray[j])
                    {
                        intList.Remove(intArray[j]);
                    }
                }
            }

            intList.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}

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

        /// <summary>
        /// https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/21/
        /// </summary>
        /// <param name="intArray"></param>
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


        /// <summary>
        /// https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/22/
        /// </summary>
        /// <param name="prices"></param>
        public void MaxProfit(int[] prices)
        {
            var intList = prices.ToList();
            var result = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i-1])
                {
                    result += prices[i] - prices[i - 1];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    public class InfoSysInterviewQ2
    {
        public void StartUp()
        {
            Console.WriteLine("Start FizzBuzz Program");
            var arguments = InputArguments();
            var p1 = arguments[0];
            var d1 = arguments[1];
            var d2 = arguments[2];

            // loop through the logic
            for (int i = 1; i <= p1; i++)
            {
                if (i % d1 != 0 && i % d2 != 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % d1 == 0 && i % d2 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % d1 != 0 && i % d2 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % d1 == 0 && i % d2 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// check the input value to match the number
        /// </summary>
        /// <returns></returns>
        private int[] InputArguments()
        {
            var inputStr = string.Empty;
            var nums = new int[3];
            string[] arguments = { };
            var loop = true;
            while (loop)
            {
                Console.Write("Console input:");
                inputStr = Console.ReadLine();
                arguments = inputStr.Split(' ');
                if (arguments.Length == 3)
                {
                    loop = false;
                    for (int i = 0; i < arguments.Length; i++)
                    {
                        int num = 0;
                        if (int.TryParse(arguments[i], out num))
                        {
                            nums[i] = num;
                        }
                        else
                        {
                            loop = true;
                            Console.WriteLine("Input error.Please input again.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Input error.Please input again.");
                }
            }
            return nums;
        }
    }
}

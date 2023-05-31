using System;
using System.Linq;

namespace P5.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] strongNumbersArray = new int[inputArray.Length];

            int strongNumber = 0;

            for (int i = 0; i < inputArray.Length-1; i++)
            {
                if (inputArray[i] > inputArray[i + 1] && i + 1 < inputArray.Length)
                {
                    strongNumber = inputArray[i];
                    strongNumbersArray[i] = strongNumber;
                }


            }
            Console.WriteLine(string.Join(" ", strongNumbersArray));
        }
    }
}

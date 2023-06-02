using System;
using System.Drawing;
using System.Linq;

namespace P5.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();
            int[] numbers = new int[inputArray.Length];


            for (int i = 0; i < inputArray.Length; i++)
            {
                numbers[i] = int.Parse(inputArray[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isBigger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger) // true
                {
                    Console.Write($"{numbers[i]} ");
                }

            }

        }
    }
}

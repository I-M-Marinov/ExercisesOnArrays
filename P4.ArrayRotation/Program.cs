using System;
using System.Linq;

namespace P4.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rotatedArray = new int[inputArray.Length - 1];

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int firstElement = inputArray[0];

                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }

                inputArray[inputArray.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}


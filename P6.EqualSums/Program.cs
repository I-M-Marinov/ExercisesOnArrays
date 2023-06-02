using System;
using System.Linq;

namespace P6.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int position = 0;

            for (int i = 0; i < inputNumbersArray.Length; i++) // iterate the array
            {
                position = -1; // set to -1 so it can start from the 1st element
                int leftSum = 0; // restart the values of the left sum
                int rightSum = 0; // restart the values of the right sum

                for (int j = i - 1; j >= 0; j--) // check the elements to the left of the element
                {
                    leftSum += inputNumbersArray[j];
                }

                for (int j = i + 1; j < inputNumbersArray.Length; j++) // check the elements to the right of the element
                {
                    rightSum += inputNumbersArray[j]; 
                }

                if (leftSum == rightSum) // check if the sum of elements to the left and right are equal
                {
                    position = i;
                    break;
                }
            }

            if (position != -1)
            {
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

using System;
using System.Linq;

namespace P8.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersArray.Length; i++)
            {
                for (int j = i + 1; j < numbersArray.Length; j++)
                {
                    if (numbersArray[i] + numbersArray[j] == givenNumber)
                    {
                        Console.WriteLine($"{numbersArray[i]} {numbersArray[j]}");
                    }

                }
            }
        }
    }
}

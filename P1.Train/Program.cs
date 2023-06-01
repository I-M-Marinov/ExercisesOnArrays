using System;

namespace P1.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                input[i] = passengers;
                sum += passengers;
            }

            Console.WriteLine(string.Join(" ", input));
            Console.WriteLine(sum);
        }
    }
}

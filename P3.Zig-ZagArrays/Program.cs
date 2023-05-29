using System;
namespace P3.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                array1[i] = int.Parse(input[0]);
                array2[i] = int.Parse(input[1]);
            }

            int[] zigZagArray1 = new int[n];
            int[] zigZagArray2 = new int[n];
            bool isNextArray1 = true;

            for (int i = 0; i < n; i++)
            {
                if (isNextArray1)
                {
                    zigZagArray1[i] = array1[i];
                    zigZagArray2[i] = array2[i];
                }
                else
                {
                    zigZagArray1[i] = array2[i];
                    zigZagArray2[i] = array1[i];
                }

                isNextArray1 = !isNextArray1;
            }

            Console.WriteLine(string.Join(" ", zigZagArray1));
            Console.WriteLine(string.Join(" ", zigZagArray2));
        }
    }
}


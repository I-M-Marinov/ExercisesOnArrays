using System;
using System.Linq;

namespace P2.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split().ToArray();
            string[] array2 = Console.ReadLine().Split().ToArray();


            for (int i = 0; i < array2.Length; i++)
            {
                for (int k = 0; k < array1.Length; k++)
                {
                    if (array2[i] == array1[k])
                    {
                        Console.Write($"{array2[i]} ");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}

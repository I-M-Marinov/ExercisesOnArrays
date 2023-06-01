using System;

namespace P7.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split();
            int bestCount = 0;
            string bestCountSymbol = "";

            for (int i = 0; i < inputArray.Length; i++)
            {
                int count = 1; 

                for (int j = i+1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == inputArray[j])
                    {
                        count++;

                        if (bestCount < count)
                        {
                            bestCount = count;
                            bestCountSymbol = inputArray[j];
                        }
                        
                    }
                    else
                    {
                        break;
                    }

                }
                
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{bestCountSymbol} ");
            }
        }
    }
}

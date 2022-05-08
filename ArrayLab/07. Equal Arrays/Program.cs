using System;
using System.Linq;
namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {

                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    firstSum += firstArray[i];

                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {firstSum}");
        }
    }
}

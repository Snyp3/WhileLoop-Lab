using System;

namespace P03SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());

            int sum = 0;
            while (sum < targetSum)
            {
                int currnetNumber = int.Parse(Console.ReadLine());

                sum += currnetNumber;
            }
            Console.WriteLine(sum);
        }
    }
}

using System;

namespace P04Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int nextNumber = 1;
            while (nextNumber <= number)
            {
                Console.WriteLine(nextNumber);
                nextNumber = (nextNumber * 2) + 1;
            }
        }
    }
}

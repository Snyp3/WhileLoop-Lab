using System;

namespace P06MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;

            string imput;
            while ((imput = Console.ReadLine()) != "Stop")
            {
                int currentNumber = int.Parse(imput);
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }

            }
            Console.WriteLine(maxNumber);
        }
    }
}

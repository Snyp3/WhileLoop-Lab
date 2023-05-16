using System;
using System.Globalization;

namespace P07MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input;
            int minNumber = int.MaxValue;

            
            while ((input = Console.ReadLine()) != "Stop")
            {
                int nextNumber = int.Parse(input);
                if (nextNumber <= minNumber)
                {
                    minNumber = nextNumber;
                }
               
            }
            Console.WriteLine(minNumber);
        }
    }
}

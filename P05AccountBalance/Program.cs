using System;

namespace P05AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalBalance = 0;
            string input;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double money = double.Parse(input);
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                totalBalance += money;
                Console.WriteLine($"Increase: {money:F2}");
            }
            Console.WriteLine($"Total: {totalBalance:F2}");

        }
    }
}

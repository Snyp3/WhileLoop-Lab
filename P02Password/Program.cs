using System;

namespace P02Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            string currnetPassword;
            while((currnetPassword=Console.ReadLine()) != password)// ако искам проверка на акаунта добавяам
                                                                // || userName != 
            {
                currnetPassword=currnetPassword;
            }
            Console.WriteLine($"Welcome {userName}!");
        }
    }
}

using System;

namespace ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();

            //while (word != "Stop")
            //{
            //    Console.WriteLine(word);
            //    word = Console.ReadLine();      ако този ред го няма става инфинит...          
            //
            //}
            string word;
            while((word= Console.ReadLine()) != "Stop") // по добро за следващи курсове
            {
                Console.WriteLine(word);
            }

        }
    }
}

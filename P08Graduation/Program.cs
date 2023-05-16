using System;

namespace P08Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studenNmae = Console.ReadLine();

            int currentGrade = 1;
            int repeats = 0;
            double marksSum = 0;
            bool isExcluded = false; // булев флаг .. служи за ориентация дали е бил изключен или не
            while (currentGrade <= 12)
            {
                double currentMark = double.Parse(Console.ReadLine());
                if (currentMark < 4)
                {
                    repeats++;
                    if(repeats > 1)
                    {
                        isExcluded = true;
                        break; // изключен от училище
                    }

                    continue;
                }
                marksSum += currentMark; // добавяне към сумата пращайки я на долния ред
                currentGrade++; // минава от сегашния клас към другия и така до 13 
            }
            if (isExcluded)
            {
                Console.WriteLine($"{studenNmae} has been excluded at {currentGrade} grade");
            }
            else
            {
                double avarege = marksSum / 12;  // да не се дели на currentGraed щото ще е 13 заради цикъла
                Console.WriteLine($"{studenNmae} graduated. Average grade: {avarege:f2}");
            }
        }
    }
}

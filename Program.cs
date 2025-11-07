using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Percent = 100;
            const double Month = 12;

            Console.WriteLine("введите сумму кредита");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("введите годовую процентную ставку");
            double bet = double.Parse(Console.ReadLine());
            Console.WriteLine("введите срок кредита в годах");
            double year = double.Parse(Console.ReadLine());

            double allsum = sum * (1 + (bet * year) / Percent );
            double everymonth = allsum / (year * Month);
       

            Console.WriteLine("результат:");
            Console.WriteLine($"общая сумма выплат: {Math.Round(allsum, 2):F2}");
            Console.WriteLine($"ежемесячный платеж: {Math.Round(everymonth, 2):F2}");
            Console.ReadKey(); 

        }
    }
}
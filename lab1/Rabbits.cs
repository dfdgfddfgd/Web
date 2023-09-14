using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество месяцев:");
        int months = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int rabbitPairs = 0;

        if (months < 0)
        {
            Console.WriteLine("Ошибка. Отрицательное количество месяцев");
        }
        else if (months == 0 || months == 1)
        {
            rabbitPairs = 1;
        }
        else
        {
            for (int i = 1; i <= months; i++)
            {
                rabbitPairs = a + b;
                a = b;
                b = rabbitPairs;
            }
        }

        Console.WriteLine($"Количество пар кроликов после {months} месяцев: {rabbitPairs}");
    }
}

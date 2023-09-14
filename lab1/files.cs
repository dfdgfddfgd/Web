using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Введите путь к файлу CSV:");
        string csvFilePath = "table1.csv";

        if (File.Exists(csvFilePath))
        {
            int currentRow = 0;
            int[] data = new int[0];

            foreach (string line in File.ReadLines(csvFilePath))
            {
                currentRow++;

                // Начинаем обрабатывать данные с пятой строки
                if (currentRow >= 5)
                {
                    // Разделяем строку на столбцы
                    var columns = line.Split(';').ToArray();

                    if (columns.Length >= 2 && int.TryParse(columns[1], out int value))
                    {
                        data = data.Append(value).ToArray();
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка чтения данных в строке {currentRow}");
                    }
                }
            }

            if (data.Length > 0)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("a. Максимум");
                Console.WriteLine("b. Минимум");
                Console.WriteLine("c. Среднее значение");
                Console.WriteLine("d. Исправленная выборочная дисперсия");

                char choice = Console.ReadKey().KeyChar;

                double result = 0;

                switch (choice)
                {
                    case 'a':
                        result = data.Max();
                        Console.WriteLine($"Максимум: {result}");
                        break;
                    case 'b':
                        result = data.Min();
                        Console.WriteLine($"Минимум: {result}");
                        break;
                    case 'c':
                        result = data.Average();
                        Console.WriteLine($"Среднее значение: {result}");
                        break;
                    case 'd':
                        double mean = data.Average();
                        double squaredDifferences = data.Select(x => Math.Pow(x - mean, 2)).Sum();
                        int n = data.Length;
                        result = squaredDifferences / (n - 1);
                        Console.WriteLine($"Исправленная выборочная дисперсия: {result}");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Файл CSV не содержит корректных данных для анализа.");
            }
        }
        else
        {
            Console.WriteLine("Указанный файл CSV не существует.");
        }
    }
}

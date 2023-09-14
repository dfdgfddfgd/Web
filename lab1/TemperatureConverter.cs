using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение градусов:");
        double temperature = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите шкалу исходной температуры (C, K, F):");
        string sourceScale = Console.ReadLine().ToUpper();

        Console.WriteLine("Введите шкалу, в которую необходимо перевести (C, K, F):");
        string targetScale = Console.ReadLine().ToUpper();
        double convertedTemperature = 0;

        if (targetScale != "C" && targetScale != "K" && targetScale != "F")
        {
            Console.WriteLine("Неподдерживаемая шкала, в которую необходимо перевести");
            return;
        }
        
        if (sourceScale == "C")
        {
            if (targetScale == "K")
            {
                convertedTemperature = temperature + 273.15;
            }
            else if (targetScale == "F")
            {
                convertedTemperature = (temperature * 9 / 5) + 32;
            }
            else
            {
                convertedTemperature = temperature;
            }
        }
        else if (sourceScale == "K")
        {
            if (targetScale == "C")
            {
                convertedTemperature = temperature - 273.15;
            }
            else if (targetScale == "F")
            {
                convertedTemperature = (temperature - 273.15) * 9 / 5 + 32;
            }
            else
            {
                convertedTemperature = temperature;
            }
        }
        else if (sourceScale == "F")
        {
            if (targetScale == "C")
            {
                convertedTemperature = (temperature - 32) * 5 / 9;
            }
            else if (targetScale == "K")
            {
                convertedTemperature = (temperature - 32) * 5 / 9 + 273.15;
            }
            else
            {
                convertedTemperature = temperature;
            }
        }
        else
        {
            Console.WriteLine("Неподдерживаемая исходная шкала.");
            return;
        }

        Console.WriteLine($"Результат: {convertedTemperature} {targetScale}");
    }
}

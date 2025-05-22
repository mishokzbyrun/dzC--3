using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введіть номер завдання (1-9) або '0' для виходу:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": Task1_FizzBuzz(); break;
                case "2": Task2_Percentage(); break;
                case "3": Task3_FourDigitsToNumber(); break;
                case "4": Task4_SwapDigits(); break;
                case "5": Task5_DateSeasonAndDay(); break;
                case "6": Task6_TemperatureConverter(); break;
                case "7": Task7_EvenNumbersInRange(); break;
                case "8": Task8_Armstrong(); break;
                case "9": Task9_PerfectNumber(); break;
                case "0": return;
                default: Console.WriteLine("Невірний номер завдання."); break;
            }

            Console.WriteLine();
        }
    }

    static void Task1_FizzBuzz()
    {
        Console.WriteLine("Введіть число від 1 до 100:");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 100)
        {
            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("Fizz Buzz");
            else if (number % 3 == 0)
                Console.WriteLine("Fizz");
            else if (number % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Помилка: число має бути від 1 до 100.");
        }
    }

    static void Task2_Percentage()
    {
        Console.WriteLine("Введіть два числа (значення і відсоток):");
        double value = double.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());
        double result = value * percent / 100;
        Console.WriteLine($"Результат: {result}");
    }

    static void Task3_FourDigitsToNumber()
    {
        Console.WriteLine("Введіть 4 цифри:");
        string number = "";
        for (int i = 0; i < 4; i++)
        {
            number += Console.ReadLine();
        }
        Console.WriteLine($"Результат: {number}");
    }

    static void Task4_SwapDigits()
    {
        Console.WriteLine("Введіть шестизначне число:");
        string num = Console.ReadLine();
        if (num.Length != 6)
        {
            Console.WriteLine("Помилка: число має бути шестизначним.");
            return;
        }

        Console.WriteLine("Введіть два номери позицій (1-6):");
        int pos1 = int.Parse(Console.ReadLine()) - 1;
        int pos2 = int.Parse(Console.ReadLine()) - 1;

        char[] chars = num.ToCharArray();
        (chars[pos1], chars[pos2]) = (chars[pos2], chars[pos1]);

        Console.WriteLine($"Результат: {new string(chars)}");
    }

    static void Task5_DateSeasonAndDay()
    {
        Console.WriteLine("Введіть дату (дд.мм.рррр):");
        string dateStr = Console.ReadLine();
        if (DateTime.TryParseExact(dateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            string season = date.Month switch
            {
                12 or 1 or 2 => "Winter",
                3 or 4 or 5 => "Spring",
                6 or 7 or 8 => "Summer",
                9 or 10 or 11 => "Autumn",
                _ => "Unknown"
            };
            Console.WriteLine($"{season} {date.DayOfWeek}");
        }
        else
        {
            Console.WriteLine("Неправильний формат дати.");
        }
    }

    static void Task6_TemperatureConverter()
    {
        Console.WriteLine("Введіть температуру:");
        double temp = double.Parse(Console.ReadLine());

        Console.WriteLine("1 - з Фаренгейта в Цельсій, 2 - з Цельсія в Фаренгейт");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            double celsius = (temp - 32) * 5 / 9;
            Console.WriteLine($"У Цельсії: {celsius}");
        }
        else if (choice == "2")
        {
            double fahrenheit = temp * 9 / 5 + 32;
            Console.WriteLine($"У Фаренгейтах: {fahrenheit}");
        }
        else
        {
            Console.WriteLine("Невірний вибір.");
        }
    }

    static void Task7_EvenNumbersInRange()
    {
        Console.WriteLine("Введіть два числа (початок і кінець діапазону):");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int start = Math.Min(a, b);
        int end = Math.Max(a, b);

        Console.WriteLine("Парні числа:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
                Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    static void Task8_Armstrong()
    {
        Console.WriteLine("Введіть число:");
        string number = Console.ReadLine();
        int sum = 0, n = number.Length;
        foreach (char c in number)
        {
            int digit = c - '0';
            sum += (int)Math.Pow(digit, n);
        }

        if (int.Parse(number) == sum)
            Console.WriteLine("Це число Армстронга.");
        else
            Console.WriteLine("Це НЕ число Армстронга.");
    }

    static void Task9_PerfectNumber()
    {
        Console.WriteLine("Введіть число:");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                sum += i;
        }

        if (sum == number)
            Console.WriteLine("Це досконале число.");
        else
            Console.WriteLine("Це НЕ досконале число.");
    }
}

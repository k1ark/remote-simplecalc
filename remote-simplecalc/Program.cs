using System;

class SimpleCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Простой калькулятор:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");

        Console.Write("Выберите операцию (1/2/3/4): ");
        string choice = Console.ReadLine();

        if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
        {
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Результат: {num1 + num2}");
                    break;
                case "2":
                    Console.WriteLine($"Результат: {num1 - num2}");
                    break;
                case "3":
                    Console.WriteLine($"Результат: {num1 * num2}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Результат: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Некорректный выбор");
        }
        Console.WriteLine("\nНажмите любую клавишу, чтобы выйти...");
        Console.ReadKey();
    }
}
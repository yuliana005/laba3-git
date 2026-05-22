using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            bool alive = true;

            while (alive)
            {
                Console.WriteLine("\n--- Меню калькулятора ---");
                Console.WriteLine("1. Ввести А");
                Console.WriteLine("2. Ввести В");
                Console.WriteLine("3. Выполнить операцию '+'");
                Console.WriteLine("4. Выполнить операцию '-'");
                Console.WriteLine("5. Выполнить операцию '*'");
                Console.WriteLine("6. Выполнить операцию '/'");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");

                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.Write("Введите значение A: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Введите значение B: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "3":
                        // Выполнение сложения для переменных a и b
                        Console.WriteLine($"Результат: {a} + {b} = {a + b}");
                        break;
                    case "4":
                        // Выполнение вычитания для переменных a и b
                        Console.WriteLine($"Результат: {a} - {b} = {a - b}");
                        break;
                    case "5":
                        // Выполнение умножения для переменных a и b
                        Console.WriteLine($"Результат: {a} * {b} = {a * b}");
                        break;
                    case "6":
                        if (b != 0)
                            Console.WriteLine($"Результат: {a} / {b} = {a / b}");
                        else
                            Console.WriteLine("Ошибка: деление на ноль!");
                        break;
                    case "0":
                        alive = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }
}
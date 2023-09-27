using System;

class Program
{
    static void Main()
    {
        double result = 0;
        bool exit = false;

        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите первое число: ");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double num2 = double.Parse(Console.ReadLine());
                        result = num1 + num2;
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case 2:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case 3:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case 4:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Результат: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль.");
                        }
                        break;

                    case 5:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        int exponent = int.Parse(Console.ReadLine());
                        result = Math.Pow(num1, exponent);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case 6:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        if (num1 >= 0)
                        {
                            result = Math.Sqrt(num1);
                            Console.WriteLine($"Результат: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: нельзя извлечь корень из отрицательного числа.");
                        }
                        break;

                    case 7:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        result = num1 / 100;
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case 8:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        result = Factorial(num1);
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case 9:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор операции.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректный номер операции.");
            }

        } while (!exit);
    }

    static double Factorial(double num)
    {
        if (num == 0)
        {
            return 1;
        }
        double result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}

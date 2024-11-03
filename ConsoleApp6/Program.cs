using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Калькулятор");

            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double result = number1 + number2;

            Console.WriteLine($"Результат сложения: {number1} + {number2} = {result}");

            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}

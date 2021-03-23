using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1: ");
            int firstNumber = 0;
            if (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Ошибка! Некорректное первое число!");
                return;
            }

            Console.WriteLine("Введите число 2: ");
            int secondNumber = 0;
            if (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Ошибка! Некорректное второе число!");
                return;
            }

            Console.WriteLine("Введите операцию: ");
            char operation = char.Parse(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.WriteLine(Add(firstNumber, secondNumber));
                    break;
                case '-':
                    Console.WriteLine(Sub(firstNumber, secondNumber));
                    break;
                case '*':
                    Console.WriteLine(Mul(firstNumber, secondNumber));
                    break;
                case '/':
                    Console.WriteLine(Div(firstNumber, secondNumber));
                    break;
                default:
                    Console.WriteLine("Ошибка! Некорректная операция");
                    break;
            }
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int Mul(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static int Div(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}

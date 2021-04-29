using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        private static void Calculator()
        {
            Console.Write("Введите 1-е число: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите 2-е число: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите действие: ");
            string action = Console.ReadLine();

            if (action.Equals("+"))
            {
                Console.WriteLine($"{firstNum} {action} {secondNum} = {Sum(firstNum, secondNum)}");
            }
            else if (action.Equals("-"))
            {
                Console.WriteLine($"{firstNum} {action} {secondNum} = {Subtraction(firstNum, secondNum)}");
            }
            else if (action.Equals("/"))
            {
                Console.WriteLine($"{firstNum} {action} {secondNum} = {Division(firstNum, secondNum)}");
            }
            else if (action.Equals("*"))
            {
                Console.WriteLine($"{firstNum} {action} {secondNum} = {Multiplication(firstNum, secondNum)}");
            }
            else if (action.Equals("%"))
            {
                Console.WriteLine($"{firstNum} {action} {secondNum} = {RemainderDivision(firstNum, secondNum)}");
            }
            else
            {
                Console.WriteLine("Такого действия нет!");
                Calculator();
            }
            Console.ReadKey();
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }

        public static double RemainderDivision(double a, double b)
        {
            return a % b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }
    }
}

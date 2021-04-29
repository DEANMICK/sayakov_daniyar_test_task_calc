using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = Convert.ToInt32(Console.ReadLine());
            double secondNum = Convert.ToInt32(Console.ReadLine());
            string action = Console.ReadLine();
            if (action.Equals("+"))
            {
                Console.WriteLine(firstNum + " " + action + " " + secondNum + " = " + Sum(firstNum, secondNum));
            }
            else if (action.Equals("-"))
            {
                Console.WriteLine(firstNum + " " + action + " " + secondNum + " = " + Subtraction(firstNum, secondNum));
            }
            else if (action.Equals("/"))
            {
                Console.WriteLine(firstNum + " " + action + " " + secondNum + " = " + Division(firstNum, secondNum));
            }
            else if (action.Equals("*"))
            {
                Console.WriteLine(firstNum + " " + action + " " + secondNum + " = " + Multiplication(firstNum, secondNum));
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

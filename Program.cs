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

            double getFirstNum = 0;
            double getSecondNum = 0;

            if (Convert.ToDouble(firstNum) != (Convert.ToInt32(firstNum)) && Convert.ToDouble(secondNum) != (Convert.ToInt32(secondNum)))
            {
                Console.WriteLine($"Ход решения:\n1) Так как число {firstNum} и {secondNum} являются дробными то преобразуем их в целочисленные");
                getFirstNum = numberConversion(firstNum);
                getSecondNum = numberConversion(secondNum);
            } else if (Convert.ToDouble(firstNum) != (Convert.ToInt32(firstNum)))
            {
                Console.WriteLine($"Ход решения:\n1) Так как число {firstNum} является дробным то преобразую его в целочисленное");
                getFirstNum = numberConversion(firstNum);
                Console.WriteLine($"{getFirstNum}");
            }
            else if (Convert.ToDouble(secondNum) != (Convert.ToInt32(secondNum)))
            {
                Console.WriteLine($"Ход решения:\n1) Так как число {secondNum} является дробным то преобразую его в целочисленное");
                getSecondNum = numberConversion(secondNum);
                Console.WriteLine($"{getSecondNum}");
            }

            double result = 0;

            if (action.Equals("+"))
            {
                Console.WriteLine($"{firstNum} {action} {secondNum} = {Sum(getFirstNum, getSecondNum)}");
            }
            else if (action.Equals("-"))
            {
                Console.WriteLine($"{firstNum} {action} {secondNum} = {Subtraction(getFirstNum, getSecondNum)}");
            }
            else if (action.Equals("/"))
            {
                result = Division(getFirstNum, getSecondNum);
                Console.WriteLine($"{firstNum} {action} {secondNum} = {Math.Round(result, 4)}");
            }
            else if (action.Equals("*"))
            {
                result = Multiplication(getFirstNum, getSecondNum);
                if (result > 9999)
                {
                    result /= 10000;
                } else if (result > 999)
                {
                    result /= 10000;
                }
                Console.WriteLine($"{firstNum} {action} {secondNum} = {Math.Round(result, 3)}");
            }
            else if (action.Equals("%"))
            {
                Console.WriteLine($"{firstNum} {action} {secondNum} = {RemainderDivision(getFirstNum, getSecondNum)}");
            }
            else
            {
                Console.WriteLine("Такого действия нет!");
                Calculator();
            }
            Console.ReadKey();
        }

        private static double numberConversion(double firstNum)
        {
            Console.WriteLine($"2) Так как число {firstNum} является дробным, то округлим его до 2-х чисел после запятой: {Math.Round(firstNum, 2)}");
            double roundNum = Math.Round(firstNum, 2) * 100;
            Console.WriteLine($"3) Теперь домножим для целочисленности на 100: {roundNum}");
            return roundNum;
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

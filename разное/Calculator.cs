using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разное
{
    class Calculator
    {
        public static void Calc()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите первое число");
                Console.ForegroundColor = ConsoleColor.White;
                string s = Console.ReadLine();

                if (Exit(s) == true)
                {
                    return;
                }

                try
                {
               
                    int FirstNumber = Convert.ToInt32(s);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите второе число");
                    Console.ForegroundColor = ConsoleColor.White;
                    s = Console.ReadLine();
                    if (Exit(s) == true)
                    {
                        return;
                    }
                    int SecondNumber = Convert.ToInt32(s);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите действие (+|-|*|/|");
                    Console.ForegroundColor = ConsoleColor.White;
                    s = Console.ReadLine();
                    if (Exit(s) == true)
                    {
                        return;
                    }
                    string Operator = s;

                    switch (Operator)
                    {
                        case "-":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Результат равен = {0}",  FirstNumber - SecondNumber);
                            break;
                        case "+":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Результат равен = {0}", FirstNumber + SecondNumber);
                            break;
                        case "*":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Результат равен = {0}", FirstNumber * SecondNumber);
                            break;
                        case "/":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Результат равен = {0}", FirstNumber / SecondNumber);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы ввели не верно");
                            
                            break;
                    }

                }

                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вызвана ошибка. {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static bool Exit(string s)
        {
            if (s == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("конец программы");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                return true;
            }
            return false;
        }
    }
}

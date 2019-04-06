using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разное
{
    class Program
    {
        static void Main(string[] args)
        {

             string command = "";
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Приветствуем в этом сборнике. Вы можете ввести номер программы и перейти в нее. Или введите | Help |\n" +
                    "Нажмите номер программы и перейдите в нее:\n" +
                    "нажмите 1 - Калькулятор\n" +
                    "нажмите 2 - Допуск по имени\n" +
                    "нажмите 3 - Обратный отсчет\n" +
                    "нажмите 4 - 18+\n" +
                    "нажмите 5 - Поздравления со всеми прошедшими Днями Рождения\n" +
                    "нажмите 6 - Вопросы");
                command = Console.ReadLine();
                Console.Clear();
                switch (command)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----Calculator----\n__________________\n");
                        Exit.ExitEx();
                        Calculator.Calc();
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----Enter Your Name----\n___________________\n");
                        Exit.ExitEx();
                        EnterYourName.EnterName();
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----Account----\n________________\n");
                        Exit.ExitEx();
                        Account.Acc();
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----18+----\n___________\n");
                        Exit.ExitEx();
                        _18_.Eighteen();
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----Birthday----\n________________\n");
                        Exit.ExitEx();
                        Birthday.Birth();
                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----Names----\n_____________\n");
                        Exit.ExitEx();
                        Names.Name();
                        break;
                    case "Help":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----Help----\n____________\n");
                        Exit.ExitEx();
                        ShowHelp();
                        break;
                }

            }
            while (command != "exit");
        }
        
        private static void ShowHelp()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Calculator - калькулятор двух чисел\n" +
                "Enter Your Name - пропуск в приложение по имени\n" +
                "Account - отсчет до нуля\n" +
                "18+ - проверка возраста\n" +
                "Birthday - введите количество лет и Мы Вас поздравим сразу за все годы\n" +
                "Names - вводим наши имена и получаем вопрос");
            Console.ReadLine();
        }
    }
}

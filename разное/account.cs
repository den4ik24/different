using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разное
{
    class Account
    {
        public static void Acc()
        {
            Console.Title = "Обратный отсчет";
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("enter your number");
                Console.WriteLine();

                string exit = Console.ReadLine();
                if (Exit.AllExit(ref exit) == true)
                {
                    return;
                }

                try
                 {
                    Console.WriteLine();
                    int count = Convert.ToInt32(exit);

                    for (int i = count; i >= 0; i--)
                    {
                        Console.WriteLine(i);
                    }

                    //for (int i = 0; i <= count; i++)
                    //{
                    //    Console.WriteLine(i);
                    //}

                }
                catch (FormatException ex)
                 {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы ввели не число. {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                 }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ПУСК !!!!!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("конец программы");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
    }
}

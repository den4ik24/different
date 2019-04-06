using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разное
{
    class EnterYourName
    {
        public static void EnterName()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("enter your name");

                string exit = Console.ReadLine();
                if (exit == "exit")
                {
                    Exit.AllExit();
                    return;
                }

                if (exit == "Denis" || exit == "Yurchenko" | exit == "admin")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Hello {exit} !");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"You shell not pass, {exit}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}

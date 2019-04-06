using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разное
{
    class Birthday
    {
        public static void Birth()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("enter your age");

                string exit = Console.ReadLine();
                if (exit == "exit")
                {
                    Exit.AllExit();
                    return;
                }

                try
                {
                    
                    int age = Convert.ToInt32(exit);
                    while (age > 0)
                    {
                        Console.WriteLine("Happy birthday");
                        age--;
                    }

                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы ввели не число. {ex.Message}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }
        }
    }

}

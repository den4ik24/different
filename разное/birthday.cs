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
            Console.Title = "Поздравлялки с ДР";
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("enter your age");

                string exit = Console.ReadLine();
                if (Exit.AllExit(ref exit) == true)
                {
                    return;
                }

                try
                {
                    
                    int age = Convert.ToInt32(exit);
                    string Birth = "Happy birthday ! ";
                    while (age > 0)
                    {
                        foreach(var BirthInString in Birth)
                        {
                            Console.WriteLine(BirthInString);
                        }

                        //Console.WriteLine("Happy birthday");
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

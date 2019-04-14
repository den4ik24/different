using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разное
{
    class Names
    {
        public static void Name()
        {
            while (true)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Hi \n enter your name");
                Console.ForegroundColor = ConsoleColor.White;
                string exit = Console.ReadLine();
                if (exit == "exit")
                {
                    //Exit.AllExit();
                    return;
                }

                switch (exit)
                {
                    case "Denis":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Hello {exit}, how are you ?");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "Diana":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Hello {exit}, Ты завтра идешь в школу ?");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "Anna":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Привет {exit} как дела ?");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "Igor":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Привет {exit} еще не спишь ?");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Таки Ваше имя не кошерное :-)");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
            }
        }
    }
}

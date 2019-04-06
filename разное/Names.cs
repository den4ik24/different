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
                Console.WriteLine("Hi \n enter your name");

                string exit = Console.ReadLine();
                if (exit == "exit")
                {
                    Exit.AllExit();
                    return;
                }

                switch (exit)
                {
                    case "Denis":
                        Console.WriteLine($"Hello {exit}, how are you ?");
                        break;
                    case "Diana":
                        Console.WriteLine($"Hello {exit}, Ты завтра идешь в школу ?");
                        break;
                    case "Anna":
                        Console.WriteLine($"Привет {exit} как дела ?");
                        break;
                    case "Igor":
                        Console.WriteLine($"Привет {exit} еще не спишь ?");
                        break;
                    default:
                        Console.WriteLine("Таки Ваше имя не кошерное :-)");
                        break;

                }
            }
        }
    }
}

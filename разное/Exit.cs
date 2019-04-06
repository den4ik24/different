using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разное
{
    class Exit
    {
        public static void AllExit()
        {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Конец программы");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.WriteLine();
            
        }

        public static void ExitEx()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Для выхода введите exit\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

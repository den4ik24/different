using System;

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

                string exit;
                //string exit = Exit.AllExit(ref exit);
                if (Exit.AllExit(ref exit) == true)
                {
                    return;
                }
                else
                {

                    if (exit == "Denis" || exit == "Yurchenko" || exit == "admin")
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
}

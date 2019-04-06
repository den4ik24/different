﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разное
{
    class _18_
    {
        public static void Eighteen()
        {
            Console.ForegroundColor = ConsoleColor.White;
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
                    if (age >= 18 && age <= 55)
                    {
                        Console.WriteLine("Вы приняты");
                    }
                    else
                    {
                        Console.WriteLine("ga away");
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

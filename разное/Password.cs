using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разное
{
    class Password
    {
        public static void Pass()
        {
            Console.Title = "ПАРОЛЬ";
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("Сначала введите Имя и нажмите ENTER, после введите Пароль и тоже подтвердите нажав ENTER");
                User exit = new User(Console.ReadLine(), Console.ReadLine());

                if (Exit.AllExit (ref exit) == true)
                {
                    return;
                }
                Console.WriteLine($"Создан новый пользователь {exit.UserName}");
                Console.WriteLine("Вы знаете пароль: ");

                for (int i = 0; i <= 3; i++)
                  

                    if (exit.IsPasswordValid(Console.ReadLine()))
                    {
                        Console.WriteLine($"Привет, {exit.UserName}, добро пожаловать");
                        break;
                    }

                    else
                    {

                        Console.WriteLine("неверный пароль, нажмите ENTER");
                        switch (i + 1)
                        {
                            case 1:
                                Console.WriteLine("У вас есть 3 попытки");
                                Console.WriteLine("Попытка №1");
                                break;
                            case 2:
                                Console.WriteLine("У вас осталось 2 попытки");
                                Console.WriteLine("Попытка №2");
                                break;
                            case 3:
                                Console.WriteLine("У вас последняя попытка");
                                Console.WriteLine("Попытка №3");
                                break;
                            default:
                                Console.WriteLine("Ваши попытки истекли");
                                break;
                        }
                    }
                Console.WriteLine();
                Console.WriteLine($"Число вводов: {User.UserCount}, нажмите ENTER");
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }

    class User
    {
        public string UserName;
        public string UserPassword;
        public static int UserCount;
        

        public User(string UserName, string UserPassword)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            UserCount++;
        }
        public void ChangePassord(string Password)
        {
            UserPassword = Password;
        }
        public bool IsPasswordValid(string Password)
        {
            return UserPassword == Password;
        }

    }
}

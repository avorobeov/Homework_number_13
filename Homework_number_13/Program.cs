using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_number_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandToSetName = "SetName";
            const string CommandToChangeColourConsole = "ChangeConsoleColor";
            const string CommandToSetPassword = "SetPassword";
            const string CommandToWriteName = "WriteName";
            const string CommandStop = "Esc";

            bool isExit = false;
            string userName = "";
            string userPasword = "";
            string inputUser;

            while (isExit == false)
            {
                Console.WriteLine("Выберите команду из списка:\n" +
                                  "SetName – установить имя\n" +
                                  "ChangeConsoleColor- изменить цвет консоли\n" +
                                  "SetPassword – установить пароль\n" +
                                  "WriteName – вывести имя (после ввода пароля)\n" +
                                  "Esc – выход из программы\n");
                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case CommandToSetName:
                        Console.Write("Укажите имя пользователя: ");

                        inputUser = Console.ReadLine();
                        userName = inputUser;

                        Console.WriteLine($"Имя успешно изменено : {userName}");
                        break;

                    case CommandToChangeColourConsole:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();

                        Console.WriteLine("Цвет консоли успешно сменён на синий");
                        break;

                    case CommandToSetPassword:
                        Console.WriteLine("Укажите пароль: ");

                        inputUser = Console.ReadLine();
                        userPasword = inputUser;

                        Console.WriteLine($"Пароль успешно изменён : {userPasword}");
                        break;

                    case CommandToWriteName:
                        if (string.IsNullOrEmpty(userPasword))
                        {
                            Console.WriteLine("Эта команда станет доступной только после того как вы установите пароль !");
                        }
                        else
                        {
                            Console.WriteLine($"Имя пользователя: {userName}");
                        }
                        break;

                    case CommandStop:
                        isExit = true;
                        break;

                    default:
                        Console.WriteLine($"Такой команды нет (:");
                        Console.Clear();
                        break;

                }
            }
        }
    }
}

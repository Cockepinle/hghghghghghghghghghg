using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Class1
    {

        public static void clear()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
        public static int Strelka()
        {
            int position = 1;
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine(" ");

                if (key.Key == ConsoleKey.UpArrow && position != 1)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow && position != 3)
                {
                    position++;
                }

            } while (key.Key != ConsoleKey.Enter);

            return position;
        }
        public static void Zapisi(int position, string date)
        {
            if (position == 1)
            {
                Console.SetCursorPosition(0, 6);
                clear();

                Console.SetCursorPosition(0, 5);
                if (date == "13.10.2023 0:00:00")
                {
                    Console.WriteLine("Название: Тренировка");
                }
                else if (date == "14.10.2023 0:00:00")
                {
                    Console.WriteLine("Название: Купить продукты");
                }
                else if (date == "15.10.2023 0:00:00")
                {
                    Console.WriteLine("Название: Помыть окна");
                }

                Console.SetCursorPosition(0, 8);

                clear();

                Console.SetCursorPosition(0, 7);
                if (date == "13.10.2023 0:00:00")
                {
                    Console.WriteLine("Описание: Нужно сходить на тренировку по йоге");
                }
                else if (date == "14.10.2023 0:00:00")
                {
                    Console.WriteLine("Описание: Нужно купить молоко и хлеб");
                }
                else if (date == "15.10.2023 0:00:00")
                {
                    Console.WriteLine("Описание: Нужно вымыть окна в зале");
                }

                Console.SetCursorPosition(0, 10);
                clear();

                Console.SetCursorPosition(0, 9);
            }

            else if (position == 2)
            {
                Console.SetCursorPosition(0, 6);
                clear();

                Console.SetCursorPosition(0, 5);
                if (date == "13.10.2023 0:00:00")
                {
                    Console.WriteLine("Название: Чтение");
                }
                else if (date == "14.10.2023 0:00:00")
                {
                    Console.WriteLine("Название: Сходить к бабушке");
                }
                else if (date == "15.10.2023 0:00:00")
                {
                    Console.WriteLine("Название: Починить замок");
                }

                Console.SetCursorPosition(0, 8);

                clear();

                Console.SetCursorPosition(0, 7);
                if (date == "13.10.2023 0:00:00")
                {
                    Console.WriteLine("Описание: Нужно почитать книгу");
                }
                else if (date == "14.10.2023 0:00:00")
                {
                    Console.WriteLine("Описание: Нужно сходить к бабушке");
                }
                else if (date == "15.10.2023 0:00:00")
                {
                    Console.WriteLine("Описание: Нужно починить замок от кухни");
                }

                Console.SetCursorPosition(0, 10);
                clear();

                Console.SetCursorPosition(0, 9);

            }
            else if (position == 3)
            {
                Console.SetCursorPosition(0, 6);
                clear();

                Console.SetCursorPosition(0, 5);
                if (date == "13.10.2023 0:00:00")
                {
                    Console.WriteLine("Название: Уборка");
                }
                else if (date == "14.10.2023 0:00:00")
                {
                    Console.WriteLine("Название: Погулять с собакой");
                }
                else if (date == "15.10.2023 0:00:00")
                {
                    Console.WriteLine("Название: Сделать уроки");
                }

                Console.SetCursorPosition(0, 8);

                clear();

                Console.SetCursorPosition(0, 7);
                if (date == "13.10.2023 0:00:00")
                {
                    Console.WriteLine("Описание: Нужно убрать свою комнату");
                }
                else if (date == "14.10.2023 0:00:00")
                {
                    Console.WriteLine("Описание: Нужно выгулять песика");
                }
                else if (date == "15.10.2023 0:00:00")
                {
                    Console.WriteLine("Описание: Нужно сделать уроки");
                }

                Console.SetCursorPosition(0, 10);
                clear();

                Console.SetCursorPosition(0, 9);


            }

        }
    }
}

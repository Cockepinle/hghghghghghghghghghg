
using ConsoleApp17;

namespace ConsoleApp17
{

    class Program
    {
        static void Main(string[] args)

        {
            DateTime currentDate = DateTime.Today;





            while (true)
            {
                Console.WriteLine("Выбрана дата:" + currentDate.ToString());

                Console.SetCursorPosition(0, 2);
                Class1.clear();
                if (currentDate.ToString() == "13.10.2023 0:00:00")
                {

                    Console.WriteLine("  1.Тренировка");
                    Console.WriteLine("  2.Чтение");
                    Console.WriteLine("  3.Уборка");
                }
                else if (currentDate.ToString() == "14.10.2023 0:00:00")
                {
                    Console.WriteLine("  1.Купить продукты");
                    Console.WriteLine("  2.Сходить к бабушке");
                    Console.WriteLine("  3.Погулять с собакой");
                }

                else if (currentDate.ToString() == "15.10.2023 0:00:00")
                {
                    Console.WriteLine("  1.Помыть окна");
                    Console.WriteLine("  2.Починить замок");
                    Console.WriteLine("  3.Сделать уроки");
                }

                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.RightArrow)
                {
                    currentDate = currentDate.AddDays(1);
                    Console.Clear();


                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    currentDate = currentDate.AddDays(-1);
                    Console.Clear();
                }
                else if (key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow)
                {
                    Class1.Zapisi(Class1.Strelka(), currentDate.ToString());

                }





            }
        }

    }
}


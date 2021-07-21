using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            string current_date = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("Привет, " + name + ", сегодня " + current_date);
        }
    }
}

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

            /*1. Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%». 
             * Имя пользователя сохранить из консоли в промежуточную переменную. 
             * Поставить точку останова и посмотреть значение этой переменной в режиме отладки. 
             * Запустить исполняемый файл через системный терминал.*/
        }
    }
}

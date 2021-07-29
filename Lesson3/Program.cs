using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
			/*1.Написать программу, выводящую элементы двумерного массива по диагонали.*/

			/*int lengrhArr = 5;
			int[,] arr = new int[lengrhArr, lengrhArr];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (i==j)
					{
						arr[i, j] = 1;
					}
					Console.Write($"{arr[i, j]} ");
				}
				Console.WriteLine();
			}*/

			/*2.Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: 
			 * первый элемент хранит имя контакта, второй — номер телефона/ email.*/

			/* string[,] phoneListз = {
				{ "Вася", "89993564233/sss@yandex.ru" },
				{ "Петя", "89993712345/shes@yandex.ru" },
				{ "Марина", "8999378882/skfs@yandex.ru" },
				{ "Оля", "89993789331/sfqqs@yandex.ru" },
				{ "Илья", "89993789600/qqs@yandex.ru" }
			};
			foreach (var item in phoneListз)
			{
				Console.WriteLine(item);
			}*/
			/*3.Написать программу, выводящую введённую пользователем строку в обратном порядке(olleH вместо Hello).*/
			/*Console.WriteLine("Введите слово");
			string word = Console.ReadLine().ToString();
			char[] p = new char[word.Length];
			for (int i = word.Length-1; i >= 0; i--)
			{
				for (int j = 0; j < word.Length; j++)
				{
					p[j] = word[i];
				}
				Console.Write($"{p[i]} ");
			}*/


			/*«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, 
			 * где Х — элементы кораблей, а О — свободные клетки.*/
			
			char[,] marinaBattle = {
				{ 'O', 'O','O','O','X','O','O','O','O','O'},
				{ 'O', 'X','O','O','X','O','X','X','X','X'},
				{ 'O', 'O','O','O','O','O','O','O','O','O'},
				{ 'X', 'X','O','O','O','X','O','O','X','O'},
				{ 'O', 'O','O','O','O','O','O','O','O','O'},
				{ 'O', 'O','O','O','O','O','O','O','O','O'},
				{ 'O', 'X','X','X','O','O','X','X','O','O'},
				{ 'O', 'O','O','O','O','O','O','O','O','O'},
				{ 'O', 'O','O','X','O','O','X','X','X','O'},
				{ 'O', 'O','O','O','O','O','O','O','O','O'},
			};
			
			char[,] marinaField = new char[10, 10];
			char[,] marinaCheck = new char[10, 10];

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Введите координаты корабля цифру");
				int num = Convert.ToInt32(Console.Read());
				Console.WriteLine("Введите координаты корабля букву");
				char litera = Console.ReadKey().KeyChar;
				switch (litera) //не понимаю в чем ошибка
				{
					case 'а':
						marinaField[0, num] = 'X';
						break;
					case 'б':
						marinaField[1, num] = 'X';
						break;
					case 'в':
						marinaField[2, num] = 'X';
						break;
					case 'г':
						marinaField[3, num] = 'X';
						break;
					case 'д':
						marinaField[4, num] = 'X';
						break;
					case 'е':
						marinaField[5, num] = 'X';
						break;
					case 'ж':
						marinaField[6, num] = 'X';
						break;
					case 'з':
						marinaField[7, num] = 'X';
						break;
					case 'и':
						marinaField[8, num] = 'X';
						break;
					case 'к':
						marinaField[9, num] = 'X';
						break;
					
					default:
						
						break;
				}
				for (int k = 0; k < 10; k++)
				{
					for (int m = 0; m < 10; m++)
					{
						if (marinaBattle[k,m] == marinaField[k,m])
						{
							marinaCheck[k, m] = 'O';
						} else
						{
							marinaCheck[k, m] = marinaBattle[k, m];
						}
					}
					
				}
			}

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.Write($"{ marinaCheck[i, j]} ");
				}
				Console.WriteLine();
			}

		}
    }
}

using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
			//1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
			/*Console.WriteLine("Введите минимальную температуру за сутки");
			double minT = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите максимальную температуру за сутки");
			double maxT = Convert.ToDouble(Console.ReadLine());
			double averageT = (minT + maxT) / 2;
			Console.WriteLine("Средняя температура: " + averageT + "°");*/

			//2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
			/*Console.WriteLine("Введите порядковый номер текущего месяца.");
			try
			{
				int serialNumber = Convert.ToInt32(Console.ReadLine());
				switch (serialNumber)
				{
					case 1:
						Console.WriteLine("Январь");
						break;
					case 2:
						Console.WriteLine("Февраль");
						break;
					case 3:
						Console.WriteLine("Март");
						break;
					case 4:
						Console.WriteLine("Апрель");
						break;
					case 5:
						Console.WriteLine("Май");
						break;
					case 6:
						Console.WriteLine("Июнь");
						break;
					case 7:
						Console.WriteLine("Июль");
						break;
					case 8:
						Console.WriteLine("Август");
						break;
					case 9:
						Console.WriteLine("Сентябрь");
						break;
					case 10:
						Console.WriteLine("Октябрь");
						break;
					case 11:
						Console.WriteLine("Ноябрь");
						break;
					case 12:
						Console.WriteLine("Декабрь");
						break;
					default:
						Console.WriteLine("Такого месяца не существует");
						break;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Ашипка!!", e);
			}*/

			//3. Определить, является ли введённое пользователем число чётным.
			/*void Number()
			{
				Console.WriteLine("Введите ЦЕЛОЕ число");
				try
				{
					int Num = Convert.ToInt32(Console.ReadLine());
					if ((Num % 2) == 0)
					{
						Console.WriteLine("Это четное число");
					}
					else
					{
						Console.WriteLine("Это не четное число");
						Number();
					}
				}
				catch (Exception)
				{
					Console.WriteLine("Вот тут Вы не правы... ");
					Number();
				}
			}
			Number();*/

			//4. Для полного закрепления понимания простых типов найдите любой чек,
			//либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
			//только за место динамических, по вашему мнению, данных (это может быть дата,
			//название магазина, сумма покупок) подставляйте переменные,
			//которые были заранее заготовлены до вывода на консоль.
			int numCheck = 1;
			string organization = "ООО Ромашка";
			string address = "";
			string date =DateTime.Now.ToString();

			string good1 = "Груша Осенняя";
			string good2 = "Мыло";
			string good3 = "Верёвка";

			float amount1 = 1.75f;
			float amount2 = 1;
			float amount3 = 1;

			
			float price1 = 56.9f;
			float price2 = 56.9f;
			float price3 = 56.9f;

			float counter = (price1 * amount1) + (price2 * amount2) + (price3 * amount3);
			float NDS = (counter * 0.18f);

			Console.WriteLine("***************************************");
			Console.WriteLine("Кассовый чек №" +numCheck);
			Console.WriteLine(organization);
			Console.WriteLine(address);
			Console.WriteLine(date);
			Console.WriteLine("***************************************");

			Console.WriteLine(good1 + " х " + amount1 + " х " + price1 + " РУБЛЕЙ");
			Console.WriteLine(good2 + " х " + amount2 + " х " + price2 + " РУБЛЕЙ");
			Console.WriteLine(good3 + " х " + amount3 + " х " + price3 + " РУБЛЕЙ");

			Console.WriteLine("ИТОГО: " + Math.Round(counter, 2) + " РУБЛЕЙ");
			Console.WriteLine("НДС 18%: " + Math.Round(NDS, 2) + " РУБЛЕЙ");
			Console.WriteLine("***************************************");
		}
	}
}

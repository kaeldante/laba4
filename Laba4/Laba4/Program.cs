/*
 * Создано в SharpDevelop.
 * Пользователь: 123
 * Дата: 18.01.2021
 * Время: 23:17
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace Laba4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Вариант 1: Запрашивает у пользователя числа K и N и выводит на экран число K N раз");
			Console.WriteLine("===========================================================================");
			Console.Write("Введите число K: ");
			int k = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите число N: ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("===========================================================================");
			
			if (n > 0) 
            {
                for (int i = 0; i < n; i++) 
                {
                    Console.WriteLine(k);
                }
            }
			else Console.WriteLine("Число N должно быть положительным");
			
			Console.WriteLine("===========================================================================");
			Console.WriteLine("Нажмите любую клавишу....");
			
		
			Console.ReadKey();
		}
	}
}
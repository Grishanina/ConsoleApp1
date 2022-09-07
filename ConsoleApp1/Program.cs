using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Задача 1:
			Console.WriteLine("Задача 1");
			Console.WriteLine("Введите значение логарифма:");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите основание логарифма:");
			double b = Convert.ToDouble(Console.ReadLine());

			double x;

			x = Math.Log(a, b);
			Console.WriteLine("Ответ: логарифм {0} с основание {1} равен {2}", a, b, x);

			//Задача 2:
			Console.WriteLine("Задача 2");
			Console.WriteLine("Введите длинну первой стороны:");
			double c = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите длину второй стороны:");
			double d = Convert.ToDouble(Console.ReadLine());

			double x1;
			double x2;

			x1 = c + c + d + d;
			Console.WriteLine("Ответ: периметр прямоугольника равен {0}", x1);
			x2 = c * d;
			Console.WriteLine("Ответ: площадь прямоугольника равена {0}", x2);

			//Задача 4:
			Console.WriteLine("Задача 4");
			Console.WriteLine("Введите число:");
			double j = Convert.ToDouble(Console.ReadLine());




			//Задача 5:
			Console.WriteLine("Задача 5");
			Console.WriteLine("Введите значение x:");
			double n = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите значение y:");
			double m = Convert.ToDouble(Console.ReadLine());

			double x3;

			x3 = (Math.Log10(Math.Abs(Math.Cos(x))) / Math.Log10(1 + Math.Pow(x, 2)));
			Console.WriteLine("Ответ: значение выражения равно {0} ", x3);

			//Задача 7:
			Console.WriteLine("Задача 5");
			Console.WriteLine("Введите число n:");
			int e = Convert.ToInt32(Console.ReadLine());

			double v = 1/2;
			for(int i = 1; i <= e; i++)
			{
				v=v-((1+i)/(2+i));
			}
			Console.WriteLine("Ответ: {0}", v);

			//Задача 8:
			Console.WriteLine("Задача 8");
			Console.WriteLine("Введите первое действительное число:");
			int k1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите второе действительное число:");
			int k2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите третье действительное число:");
			int k3 = Convert.ToInt32(Console.ReadLine());

			if (k1 + k2 < 0)
			{
				Console.WriteLine("Сумма первого и второго числа является отрицательной!");
			}
			else if (k1 + k3 < 0)
			{
				Console.WriteLine("Сумма первого и третьего числа является отрицательной!");
			}
			else if (k2 + k3 < 0)
			{
				Console.WriteLine("Сумма второго и третьего числа является отрицательной!");
			}

		}
	}

}

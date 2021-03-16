using System;
namespace Lab_1
{
	public class Program
	{

		public static int swap1(int a, int b)
		{
			a = b;
			return a;
		}
		public static int swap2( int b, int c)
		{

			b = c;
			return b;
		}
		public static int swap3(int a, int c)
		{

			c = a;
			return c;
		}

		static void Main(String[] args)
		{

			int a = 4, b = 5, c = 6,d=a;
			Console.WriteLine("Вхідні дані a = " + a + ", b = " + b + ", c = " + c);

			
			
			Console.Write("Вихідні дані a = " + swap2(b, c) + ", b = " + swap3(d, c) + ", c = " + swap1(a, b));
		}
	}
}

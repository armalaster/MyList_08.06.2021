using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("//////////////////////////////////////////////////////////////");
			Treugolnik a = new Treugolnik(10, 5, 5, 1, "Зелёный");
			Console.WriteLine("Данные треугольника:");
			Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", a.SidelenthA, a.SidelenthB, a.SidelenthC, a.Thickness, a.Color);
			Console.WriteLine("//////////////////////////////////////////////////////////////");
			Console.WriteLine("Данные Точки:");
			Point c = new Point(2, -1, 3);
			Console.WriteLine("{0}\n{1}\n{2}", c.x, c.y, c.z);
			Console.WriteLine("//////////////////////////////////////////////////////////////");
			Console.WriteLine("Периметр треугольнка = " + a.A());
			Console.WriteLine("//////////////////////////////////////////////////////////////");
			MyList<int> list = new MyList<int>();
			list.Add(10);
			list.Add(20);
			list.Add(30);
			list.Add(40);
			list.Add(50);
			list.Add(60);
			list.Add(70);
			list.Add(80);
			list.Add(90);
			list.listPush(100);
			list.Print();
			Console.WriteLine("//////////////////////////////////////////////////////////////");
			Console.ReadKey();
		}
		public class Point
		{
			public double x;
			public double y;
			public double z;
			public Point(double x, double y, double z)
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}
		}

		class Treugolnik : Figure, Ifigure
		{
			public double SidelenthA = 10;
			public double SidelenthB = 5;
			public double SidelenthC = 5;

			public Treugolnik(double SidelenthA, double SidelenthB,
							  double SidelenthC,
							  double Thickness, string Color)
			{
				this.SidelenthA = SidelenthA;
				this.SidelenthB = SidelenthB;
				this.SidelenthC = SidelenthC;
				this.Thickness = Thickness;
				this.Color = Color;
			}
			public double A()
			{
				double P = 0;
				P = SidelenthA + SidelenthB + SidelenthC;
				return P;
			}
		}
	}
}
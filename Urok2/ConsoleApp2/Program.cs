using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true) 





			{ Console.Clear();

				Console.WriteLine("Enter purchase amout ");
				
				Double a = Convert.ToInt32(Console.ReadLine());

				if (a > 500 && a <= 1000)
					Console.WriteLine($"Purchase price including discount {a - (a * 0.03)}");
				else if (a>1000)
					Console.WriteLine($"Purchase price including discount {a - (a * 0.05)}");
			else
					Console.WriteLine($"Purchase price including discount {a}");

				Console.ReadLine();

			}

		}


} 	}  


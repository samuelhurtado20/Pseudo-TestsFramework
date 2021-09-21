using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudo_TestsFramework
{
	public class CalculateArea
	{
		const double pi = 3.1415;

		public decimal Square(decimal side){
			try
			{
				 return side * side;
			}
			catch (System.Exception)
			{
				throw;
			}
		}
		
		public decimal Rectangle(decimal b, decimal h){
			try
			{
				 return b * h;
			}
			catch (System.Exception)
			{
				throw;
			}
		}

		public decimal Triangle(decimal b, decimal h)
		{
			try
			{
				return (b * h) / 2;
			}
			catch (System.Exception)
			{
				throw;
			}
		}

		public decimal Trapeze(decimal minorBase, decimal majorBase, decimal h)
		{
			try
			{
				return (minorBase + majorBase) * h / 2;
			}
			catch (System.Exception)
			{
				throw;
			}
		}

		public double Circle(double r)
		{
			try
			{
				return (r * r) * pi;
			}
			catch (System.Exception)
			{
				throw;
			}
		}
	}
}

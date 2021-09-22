namespace Pseudo_TestsFramework
{
	public class CalculateArea
	{
		const double pi = 3.1415;

		public double Square(double side){
			try
			{
				 return side * side;
			}
			catch (System.Exception)
			{
				throw;
			}
		}
		
		public double Rectangle(double b, double h){
			try
			{
				 return b * h;
			}
			catch (System.Exception)
			{
				throw;
			}
		}

		public double Triangle(double b, double h)
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

		public double Trapeze(double minorBase, double majorBase, double h)
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

using System;

namespace Pseudo_TestsFramework
{
	class Test_CalculateArea
	{
		public static void Test_Calculate_Area_Square_Valid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Square(4);

				// Assert
				if (!CustomAssert.AreEqual(result, Convert.ToDouble(16)))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

		public static void Test_Calculate_Area_Rectangle_Valid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Rectangle(4,4);

				// Assert
				if (!CustomAssert.AreEqual(result, Convert.ToDouble(16)))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

		public static void Test_Calculate_Area_Triangle_Valid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Triangle(4, 4);

				// Assert
				if (!CustomAssert.AreEqual(result, Convert.ToDouble(8)))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

		public static void Test_Calculate_Area_Trapeze_Valid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Trapeze(2, 4, 4);

				// Assert
				if (!CustomAssert.AreEqual(result, Convert.ToDouble(12)))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

		public static void Test_Calculate_Area_Circle_Valid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Circle(4);

				// Assert
				if (!CustomAssert.AreEqual(result, 50.264))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

		public static void Test_Calculate_Area_Square_Invalid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Square(4);

				// Assert
				if (!CustomAssert.AreEqual(result, Convert.ToDouble(1)))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

		public static void Test_Calculate_Area_Rectangle_Invalid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Rectangle(4, 4);

				// Assert
				if (!CustomAssert.AreEqual(result, Convert.ToDouble(1)))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

		public static void Test_Calculate_Area_Triangle_Invalid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Triangle(4, 4);

				// Assert
				if (!CustomAssert.AreEqual(result, Convert.ToDouble(1)))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

		public static void Test_Calculate_Area_Trapeze_Invalid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Trapeze(2, 4, 4);

				// Assert
				if (!CustomAssert.AreEqual(result, Convert.ToDouble(1)))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

		public static void Test_Calculate_Area_Circle_Invalid()
		{
			try
			{
				// Arrange
				CalculateArea c = new();

				// Act
				double result = c.Circle(4);

				// Assert
				if (!CustomAssert.AreEqual(result, 1))
				{
					CustomAssert.Error();
				}
			}
			catch (Exception)
			{
				CustomAssert.Error();
			}
		}

	}
}
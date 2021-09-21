using System;
using System.Reflection;

namespace Pseudo_TestsFramework
{
	class Program
	{
		static void Main(string[] args)
		{
			var methods = typeof(CustomAsset).GetMethods();
			foreach (var method in methods)
			{
				if(!IsFromObject(method))
				{
					Console.WriteLine(method.Name);
				}
			}

			var c = new CalculateArea();
			Console.WriteLine("Circle area: " + c.Circle(4));

			Console.WriteLine(CustomAsset.AreEqual('1', '1'));
			Console.WriteLine("Hello World!");
		}

		static bool IsFromObject(MethodInfo m)
		{
			return m.DeclaringType.FullName.Contains("System");
		}
	}
}

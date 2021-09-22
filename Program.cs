using System;
using System.Reflection;

namespace Pseudo_TestsFramework
{
	class Program
	{
		static void Main(string[] args)
		{
			int valid = 0, invalid = 0;
			int option = GetOption();

			MethodInfo[] methods = typeof(Test_CalculateArea).GetMethods();
			foreach (var method in methods.FilterMethods(option))
			{
				if(!IsFromObject(method))
				{
					try
					{
						method.Invoke(null, null);
						valid++;
					}
					catch (Exception)
					{
						invalid++;
					}
				}
			}

			ShowResults(valid, invalid);
		}

		static int GetOption()
		{
			Console.WriteLine(@"All:		1");
			Console.WriteLine(@"Valid:		2");
			Console.WriteLine(@"Invalid:	3");
			ConsoleKeyInfo info = Console.ReadKey();

			if (!int.TryParse(info.KeyChar.ToString(), out int option))
			{
				option = 1;
			}

			Console.WriteLine(@"");
			Console.WriteLine(@"Option selected: " + option);
			return option;
		}

		static bool IsFromObject(MethodInfo m)
		{
			return m.DeclaringType.FullName.Contains(@"System");
		}

		static void ShowResults(int valid, int invalid)
		{
			Console.WriteLine(@"Total tests run: " + (valid + invalid));
			Console.WriteLine(@"Valid: " + valid);
			Console.WriteLine(@"InValid: " + invalid);
			Console.ReadKey();
		}
	}

}

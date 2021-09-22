using System.Linq;
using System.Reflection;

namespace Pseudo_TestsFramework
{
	public static class Extensions
	{
		public static MethodInfo[] FilterMethods(this MethodInfo[] methods, int filter)
		{
			switch (filter)
			{
				case 2:
					methods = methods.Where(x => x.Name.Contains(@"_Valid")).ToArray();
					break;
				case 3:
					methods = methods.Where(x => x.Name.Contains(@"_Invalid")).ToArray();
					break;
				default:
					break;
			}

			return methods;
		}
	}
}

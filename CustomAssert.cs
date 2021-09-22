using System;

namespace Pseudo_TestsFramework
{
	public class CustomAssert
	{
		public static bool AreEqual(object a, object b)
		{
			if (a == null && b == null) {
				return true;
			}

			return a.GetType() == b.GetType() && a.Equals(b);

		}

		public static bool AreEqual(bool a, bool b)
		{
			return a && b;
		}

		public static bool StringContains(string s, string search)
		{
			return s.Contains(search);
		}

		public static void Error()
		{
			throw new Exception(@"Assertion error");
		}
	}
}
using System;
using System.Numerics;

namespace Problem016
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;
			BigInteger Exponential = BigInteger.Pow (2, 1000);
			ulong Sum = 0;

			foreach (char c in Exponential.ToString()) {
				Sum += ulong.Parse (c.ToString());
			}

			Console.WriteLine ("Sum: {0}", Sum);

			Console.WriteLine ("Elapsed: {0}", DateTime.Now - Start);
		}
	}
}

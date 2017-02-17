using System;
using System.Numerics;
using System.Collections.Generic;

namespace Problem025
{
	class MainClass
	{
		static List<BigInteger> Fibonacci = new List<BigInteger> ();

		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;

			for (int i = 0; i < 10000000; i++) {

				Fibonacci.Add (CalculateFibonacci (i));
				Console.WriteLine("Fibonacci({0}): {1}", i, Fibonacci[i]);

				if (Fibonacci [i].ToString ().Length == 1000)
					break;
			}

			Fibonacci = null;
			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);
			System.Media.SystemSounds.Beep.Play();

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}


		static BigInteger CalculateFibonacci(int n)
		{
			if (n == 0)
				return 0;
			if (n == 1)
				return 1;

			return Fibonacci[n - 1] + Fibonacci[n - 2];
		}
	}
}

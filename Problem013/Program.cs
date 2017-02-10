using System;
using System.IO;
using System.Numerics;

namespace Problem013
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DateTime start = DateTime.Now;
			BigInteger LargeSum = new BigInteger();

			using (StreamReader sr = new StreamReader("Problem013.txt")) 
			{
				string line;
				while ((line = sr.ReadLine()) != null) 
				{
					LargeSum += BigInteger.Parse(line);
				}
			}

			Console.WriteLine ("Large Sum: {0}", LargeSum);
			Console.WriteLine ("First Ten Digits: {0}", LargeSum.ToString ().Substring (0, 10));
			Console.WriteLine ("Elapsed Time: {0}", DateTime.Now - start);
		}
	}
}
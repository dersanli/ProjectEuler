/*
 * Created by SharpDevelop.
 * User: dersanli
 * Date: 2/13/2017
 * Time: 2:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Problem001
{
	class Program
	{
		public static void Main(string[] args)
		{
			var Total = 0;
			
			for (int i = 0; i < 1000; i++) {
				if ((i % 3 == 0) || (i % 5 == 0)) {
					Total += i;
//					Console.WriteLine( "The Number divisible by 3 or 5 is: {0}",i  );
				}
			}
			
			Console.WriteLine("Total of the divisors: {0}", Total);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
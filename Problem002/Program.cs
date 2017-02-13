/*
 * Created by SharpDevelop.
 * User: dersanli
 * Date: 2/13/2017
 * Time: 2:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Problem002
{
	class Program
	{
		public static void Main(string[] args)
		{
			ulong Total = 0;

			for (uint i = 0; i < 34; i++) {
			
				ulong Fibonacci = fibonacci(i);
				
				Console.WriteLine("Fibonacci({0}): {1}", i, Fibonacci);	
				
				if (Fibonacci % 2 == 0) {
					Total += Fibonacci;
				}
				
			}
			
			Console.WriteLine("Total Even Fibonacci: {0}", Total);	
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		static ulong fibonacci(uint n)
		{
			if (n == 0)
				return 0;
			if (n == 1)
				return 1;
			
			return fibonacci(n - 1) + fibonacci(n - 2);
		}
	}
}
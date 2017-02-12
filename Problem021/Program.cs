/*
 * Created by SharpDevelop.
 * User: dersanli
 * Date: 12-Feb-17
 * Time: 4:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Problem021
{
	class Program
	{	
		static Dictionary<ulong,ulong> Numbers = new Dictionary<ulong,ulong>();
		static Dictionary<ulong,ulong> Pairs = new Dictionary<ulong,ulong>();
		
		public static void Main(string[] args)
		{
			DateTime Start = DateTime.Now;

			for (ulong i = 10000; i > 0; i--) {
				
				Numbers.Add(i, AddFactors(i));
	
			}
			
			foreach (var key in Numbers) {
				
				foreach (var value in Numbers) {
					if(key.Key == 1 || value.Value ==1)
						continue;
					
					if (key.Value == value.Value)
					{
						Pairs.Add( key.Key, value.Key);
						Console.WriteLine("{0} - {1}", key.Key, value.Key);
					}
				}
			}

			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static ulong AddFactors(ulong Number)
		{
			Console.Write("Number: {0,10}: ", Number);

			ulong SumFactors = 0;
			ulong max = (ulong)Math.Sqrt(Number);  //round down
			for (ulong factor = 1; factor <= max; ++factor) { //test from 1 to the square root, or the int below it, inclusive.
				if (Number % factor == 0) {
					SumFactors += factor;
//					Console.Write("{0} ", factor);
					if (factor != Number / factor) { // Don't add the square root twice!  Thanks Jon
						if (Number != Number / factor) {
							SumFactors += Number / factor;
//							Console.Write("{0} ", Number / factor);
						}
					}
				}
			}
			Console.Write("({0, 6})\n", SumFactors);
			return SumFactors;
		}
	}
}
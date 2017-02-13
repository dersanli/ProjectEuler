using System;
using System.Collections;

namespace Problem023
{
	/*

		A perfect number is a number for which the sum of its proper divisors is exactly equal to the number.
		For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

		A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

		As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24.
		By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.
		However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as
		the sum of two abundant numbers is less than this limit.

		Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.

	*/

	class MainClass
	{
		static SortedList AbundantNumbers = new SortedList();
		const ulong Upperlimit = 20161;

		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;

			PrepareAbundantNumbers ();

			ulong Sum = 0;

			for (ulong Number = 0; Number < 100; Number++) {
				if (!AbundantNumbers.ContainsKey (Number)) {
					if (!AbundantNumbers.ContainsKey (Upperlimit - Number)) {
						Sum += Number;
						Console.WriteLine ("Number: {0,6} - SumFactors:{1,6}", Number, Sum);
					}
				}
			}

			Console.WriteLine("Sum: {0}", Sum);
			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);
		}

		static void PrepareAbundantNumbers()
		{
			ulong SumF = 0;

			for (ulong i = 0; i < Upperlimit; i++) {

				SumF = SumFactors (i);

				if (SumF > i) {
					AbundantNumbers.Add (i, SumF);
					//Console.WriteLine ("Number: {0,6} - SumFactors:{1,6}", i, SumF);
				}
			}
		}


		static ulong SumFactors(ulong Number) {

			//Console.Write ("Number: {0,10}: ", Number);

			ulong SumFactors = 0;
			ulong max = (ulong)Math.Sqrt (Number);
			for (ulong factor = 1; factor <= max; ++factor) {
				if (Number % factor == 0) {
					SumFactors += factor;
					//Console.Write ("{0} ", factor);
					if (factor != Number / factor) {
						SumFactors += Number / factor;
						//Console.Write ("{0} ", Number / factor);
					}
				}
			}
		
			//Console.Write ("({0, 3})", NumFactors);
			return SumFactors - Number;
		}
	}
}
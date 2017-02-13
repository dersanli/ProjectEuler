using System;

namespace Problem005
{
	class Program
	{
		public static void Main(string[] args)
		{
			//const string Divisors = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20";
			ulong Number = 19 * 17 * 13 * 11 * 7 * 5 * 3 * 2; // initialize the number by multiplying the primes first
			
			int DivisibleError = -1;
			
			while (DivisibleError != 0) {
				DivisibleError = CheckDivisibility(Number);
				Console.WriteLine("The Number is {0}. Divisibility error in {1}.", Number, DivisibleError);
				if (DivisibleError % 2 == 0) {
					Number = Number * 2;
				} else if (DivisibleError % 3 == 0) {
					Number = Number * 3;
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static int CheckDivisibility(ulong Number)
		{
			for (int i = 1; i <= 20; i++) {
				if (Number % (ulong)i != 0) {
					return i;
				}
			}
			return 0;
		}
	}
}
using System;
using System.Numerics;

namespace Problem026
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;

			int MaxRecDigits = 0;

			for (int Number = 1; Number <= 1000; Number++) {
				int RecDigits = FindRecurringDigitsLength (Number);
				Console.WriteLine("Number: {0} - RecLength: {1}", Number, RecDigits );

				if (RecDigits > MaxRecDigits)
					MaxRecDigits = RecDigits;
			}


			Console.WriteLine("Maximum : {0}", MaxRecDigits);
			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);
			System.Media.SystemSounds.Beep.Play();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}


		static int FindRecurringDigitsLength( int Denominator )
		{
			int lpow = 1;

			do {
				for (int mpow = lpow - 1; mpow > -1; mpow--) {
					
					BigInteger plpow = BigInteger.Pow(10,lpow);
					BigInteger pmpow = BigInteger.Pow(10,mpow);

					BigInteger diff = plpow - pmpow;
					BigInteger denom = (BigInteger) Denominator;

					BigInteger k = new BigInteger(0);
					BigInteger.DivRem(diff, denom, out k);

					if(k.IsZero){
						return lpow - mpow;
					}

				}
				lpow++;
			} while (true);
		}
	}
}
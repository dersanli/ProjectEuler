using System;
using System.Collections.Generic;

namespace Problem021
{
	class MainClass
	{	
		static List<int> Numbers = new List<int> ();
		static List<int> Values = new List<int> ();

		public static void Main(string[] args)
		{
			DateTime Start = DateTime.Now;

			int Total = 0;

			for (int i = 10000; i > 0; i--) {

				if(AddFactors(i) < 10000){
					Numbers.Add (i);
					Values.Add (AddFactors (i));
				}
			}

			for (int NumberIndex = 0; NumberIndex < Numbers.Count; NumberIndex++) {

				int CurrentNumber = Numbers [NumberIndex];
				int CurrentValue = Values [NumberIndex];

				int CandidateNumber = 0;
				int CandidateValue = 0;

				if (CurrentValue == 1)
					continue;

				int CandidateIndex = Numbers.IndexOf (CurrentValue);

				if (CandidateIndex < 0)
					continue;

				CandidateNumber = Numbers [CandidateIndex];
				CandidateValue = Values [CandidateIndex];

				if (CandidateNumber != CurrentNumber) {
					if (CandidateValue == CurrentNumber) {
						Total += CurrentNumber;
					}
				}
			}

			Console.WriteLine ("The Total is: {0}", Total);
			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static int AddFactors(int Number)
		{
			//Console.Write("Number: {0,10}: ", Number);

			int SumFactors = 0;
			int max = (int)Math.Sqrt(Number);
			for (int factor = 1; factor <= max; ++factor) {
				if (Number % factor == 0) {
					SumFactors += factor;
//					Console.Write("{0} ", factor);
					if (factor != Number / factor) {
						if (Number != Number / factor) {
							SumFactors += Number / factor;
//							Console.Write("{0} ", Number / factor);
						}
					}
				}
			}
			//Console.Write("({0, 6})\n", SumFactors);
			return SumFactors;
		}
	}
}
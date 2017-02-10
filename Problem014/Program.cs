using System;

namespace Problem014
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DateTime start = DateTime.Now;

			uint StartingNumber = 1000000;
			uint LongestChain = 0;
			uint LongestChainNumber = 0;
			uint CurrentChain = 0;

			do {

				CurrentChain = CreateCollatzSequence(StartingNumber);

				if(LongestChain<CurrentChain){
					LongestChain = CurrentChain;
					LongestChainNumber = StartingNumber;
				}


				StartingNumber--;
			} while (StartingNumber > 0);

			Console.WriteLine ("Longest Chain: {0} @ Starting Number: {1}", LongestChain, LongestChainNumber);
			Console.WriteLine ("Elapsed: {0}", DateTime.Now - start);
		}

		static uint CreateCollatzSequence(uint StartingNumber)
		{
			Console.Write ("Starting Number: {0,8} - ", StartingNumber);
			uint CurrentTerm = StartingNumber;
			uint TermCount = 0;


			do {
				TermCount++;
				CurrentTerm = NextCollatzTerm (CurrentTerm);
			} while (CurrentTerm != 1);

			TermCount++;
			Console.WriteLine ("Term Count: {0,8}", TermCount);
			return TermCount;
		}

		static uint NextCollatzTerm(uint CollatzTerm)
		{
			if (CollatzTerm % 2 == 0) {
				return CollatzTerm / 2;
			} else {
				return CollatzTerm * 3 + 1;
			}
		}
	}
}
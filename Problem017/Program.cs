using System;

namespace Problem017
{

	/*
		If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
		If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?

		NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 
		115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.

	*/

	class MainClass
	{
		static string[] Words = new string[1001];
		static ulong LetterCount = 0;

		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;

			InitializeWords ();

			for (int i = 1; i < 1001; i++) {
				//Console.WriteLine ("Number:{0,3} - {1}", i, GenerateStingFromNumber (i));
				GenerateStingFromNumber (i);
			}

			Console.WriteLine ("Letter Count: {0}", LetterCount);

			Console.WriteLine ("Elapsed: {0}", DateTime.Now - Start);
		}

		static string GenerateStingFromNumber(int Number)
		{
			string NumberString = Number.ToString ();
			string NumberWord = string.Empty;
			int hundreds = 0, tens = 0, ones = 0;


			if (Number == 1000) {
				NumberWord = "onethousand";
			} else if (Number >= 100) {
				hundreds = int.Parse (NumberString.Substring (0, 1));
				tens = int.Parse (NumberString.Substring (1, 1));
				ones = int.Parse (NumberString.Substring (2, 1));

				if (tens == 0) {
					if (ones == 0) {
						NumberWord = Words [hundreds * 100];
					} else {
						NumberWord = Words [hundreds * 100] + "and" + Words [ones];
					}
				}
				else if (tens == 1) {
					NumberWord = Words [hundreds * 100] + "and" + Words [tens * 10 + ones];
				} else {
					NumberWord = Words [hundreds * 100] + "and" + Words [tens * 10] + Words [ones * 1];
				}
			} else if (Number > 19) {
				tens = int.Parse (NumberString.Substring (0, 1));
				ones = int.Parse (NumberString.Substring (1, 1));
				NumberWord = Words [tens * 10] + Words [ones * 1];
			} else {
				NumberWord = Words [Number];
			}

			LetterCount += (ulong)NumberWord.Length;

			return NumberWord;
		}

		static void InitializeWords()
		{
			Words [0] = string.Empty;
			Words [1] = "one";
			Words [2] = "two";
			Words [3] = "three";
			Words [4] = "four";
			Words [5] = "five";
			Words [6] = "six";
			Words [7] = "seven";
			Words [8] = "eight";
			Words [9] = "nine";
			Words [10] = "ten";
			Words [11] = "eleven";
			Words [12] = "twelve";
			Words [13] = "thirteen";
			Words [14] = "fourteen";
			Words [15] = "fifteen";
			Words [16] = "sixteen";
			Words [17] = "seventeen";
			Words [18] = "eighteen";
			Words [19] = "nineteen";
			Words [20] = "twenty";
			Words [30] = "thirty";
			Words [40] = "forty";
			Words [50] = "fifty";
			Words [60] = "sixty";
			Words [70] = "seventy";
			Words [80] = "eighty";
			Words [90] = "ninety";
			Words [100] = "onehundred";
			Words [200] = "twohundred";
			Words [300] = "threehundred";
			Words [400] = "fourhundred";
			Words [500] = "fivehundred";
			Words [600] = "sixhundred";
			Words [700] = "sevenhundred";
			Words [800] = "eighthundred";
			Words [900] = "ninehundred";
			Words [1000] = "onethousand";
		}
	}
}
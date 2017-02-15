using System;
using System.Collections.Generic;

namespace Problem024
{
	/*
		A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4.
		If all of the permutations are listed numerically or alphabetically, we call it lexicographic order.

		The lexicographic permutations of 0, 1 and 2 are:

		012   021   102   120   201   210

		What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
	*/

	class MainClass
	{

		//const int[] Digits = new int[] {0,1,2,3,4,5,6,7,8,9};
		const uint Maximum = 100;

		static List<int> UsedDigits = new List<int> ();
		static List<int> AvailableDigits = new List<int> ();

		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;

			AvailableDigits.AddRange ( new int[] {0,1,2,3,4,5,6,7,8,9} );

//			AvailableDigits.Add (0);
//			AvailableDigits.Add (1);
//			AvailableDigits.Add (2);
//			//AvailableDigits.Add (3);
//			//AvailableDigits.Add (4);
//			//AvailableDigits.Add (5);


			PrintLexicographicPermutations ();

			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);
			System.Media.SystemSounds.Beep.Play();
		}

		static void PrintLexicographicPermutations(){

			for (int i = 0; i < 10; i++) {

				AvailableDigits.Remove (i);

				List<int> AvDigits = AvailableDigits;



				for (int j = 0; j < 10; j++) {

					if (!UsedDigits.Contains (i)) {
						for (int k = 0; k < 10; k++) {

						}
					}
				}
			}
			
		}






	}
}
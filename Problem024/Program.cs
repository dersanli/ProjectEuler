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
		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;

			PrintLexicographicPermutations ();

			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);
			System.Media.SystemSounds.Beep.Play();
			Console.ReadKey();
		}
		
		static void PrintLexicographicPermutations()
		{
			
			var LexNumber = string.Empty;
			var BannedDigits = new List<int>();
			var Counter = 0;
			
			for (int i = 0; i < 10; i++) {
				BannedDigits.Add(i);
				LexNumber = i.ToString();
				
				for (int j = 0; j < 10; j++) {
					if (!BannedDigits.Contains(j)) {
						BannedDigits.Add(j);
					
						for (int k = 0; k < 10; k++) {
							if (!BannedDigits.Contains(k)) {
								BannedDigits.Add(k);
						
								for (int l = 0; l < 10; l++) {
									if (!BannedDigits.Contains(l)) {
										BannedDigits.Add(l);

										for (int m = 0; m < 10; m++) {
											if (!BannedDigits.Contains(m)) {
												BannedDigits.Add(m);
		
												for (int n = 0; n < 10; n++) {
													if (!BannedDigits.Contains(n)) {
														BannedDigits.Add(n);

														for (int p = 0; p < 10; p++) {
															if (!BannedDigits.Contains(p)) {
																BannedDigits.Add(p);
													
																for (int q = 0; q < 10; q++) {
																	if (!BannedDigits.Contains(q)) {
																		BannedDigits.Add(q);

																		for (int r = 0; r < 10; r++) {
																			if (!BannedDigits.Contains(r)) {
																				BannedDigits.Add(r);
																				
																					for (int s = 0; s < 10; s++) {
																						if (!BannedDigits.Contains(s)) {
																							BannedDigits.Add(s);
																										
																							Counter++;
																							if( Counter == 1000000){
																								LexNumber = i.ToString() + j.ToString() + k.ToString() + l.ToString() + m.ToString() + n.ToString() + p.ToString() + q.ToString() + r.ToString() + s.ToString();;
																								Console.WriteLine("{0,8}: {1}", Counter, LexNumber);
																								return;
																							}
																							BannedDigits.Remove(s);
																						}
																					}
																				BannedDigits.Remove(r);
																			}
																		}
																		BannedDigits.Remove(q);
																	}

																}
																BannedDigits.Remove(p);
															}
															
														}
														BannedDigits.Remove(n);
													}
													
												}
												BannedDigits.Remove(m);
											}
											
										}
										BannedDigits.Remove(l);
									}
																		
								}
								BannedDigits.Remove(k);
							}
							
						}
						BannedDigits.Remove(j);
					}
					
				}
				BannedDigits = new List<int>();
			}
		}
	
	}
}
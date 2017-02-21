using System;
using System.Collections.Generic;

namespace Problem028
{
	class MainClass
	{

		static int[][] Square;
		static int Edge = 1001;
		static int CurrentX = 0;
		static int CurrentY = 0;
		static int CurrentValue = 0;

		static int Step = 1;

		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;

			GenerateSquareMatrix ();
			SumDiagonals ();


			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);
			System.Media.SystemSounds.Beep.Play();
//			Console.Write("Press any key to continue . . . ");
//			Console.ReadKey(true);
		}

		static void GenerateSquareMatrix()
		{
			Square = new int[Edge][];

			for (int i = 0; i < Edge; i++) {
				int[] Row = new int[Edge];
				Square [i] = Row;
			}

			CurrentX = ((Edge - 1) / 2);
			CurrentY = ((Edge - 1) / 2);
			CurrentValue = 1;

			Square [CurrentX] [CurrentY] = CurrentValue;

			while (Step < Edge - 1) {
				for (int i = 0; i < Step; i++) {
					FillRight ();
				}
				for (int i = 0; i < Step; i++) {
					FillDown ();
				}
				Step++;

				for (int i = 0; i < Step; i++) {
					FillLeft ();
				}
				for (int i = 0; i < Step; i++) {
					FillUp ();
				}
				Step++;
			}

			for (int i = 0; i < Edge - 1; i++) {
				FillRight ();
			}

			//PrintSquare ();

		}

		static void FillRight()
		{
			if (CurrentY == Edge - 1)
				return;

			CurrentY++;
			CurrentValue++;
			Square [CurrentX] [CurrentY] = CurrentValue;
			
		}

		static void FillDown()
		{
			if (CurrentX == Edge - 1)
				return;

			CurrentX++;
			CurrentValue++;
			Square [CurrentX] [CurrentY] = CurrentValue;
		}

		static void FillLeft()
		{
			if (CurrentY == 0)
				return;

			CurrentY--;
			CurrentValue++;
			Square [CurrentX] [CurrentY] = CurrentValue;

		}

		static void FillUp()
		{
			if (CurrentX == 0)
				return;

			CurrentX--;
			CurrentValue++;
			Square [CurrentX] [CurrentY] = CurrentValue;
		}


		static void PrintSquare()
		{
			for (int i = 0; i < Square.GetLength(0); i++) {
				for (int j = 0; j < Square[i].GetLength(0); j++) {
					Console.Write ("{0,3} ", Square[i][j]);
				}
				Console.Write ("\n");
			}
			Console.Write ("\n");
		}

		static int SumDiagonals()
		{
			int SumDiagonals = 0;
			
			for (int i = 0; i < Edge; i++) {
				SumDiagonals += Square [i] [i];
				SumDiagonals += Square [Edge-i-1][i];

			}

			SumDiagonals--;

			Console.WriteLine("Sum of Diagonals: {0}", SumDiagonals);

			return SumDiagonals;
		}


	}
}

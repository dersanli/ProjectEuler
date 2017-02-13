using System;
using System.IO;
using System.Collections;

namespace Problem022
{
	class MainClass
	{
		static SortedList Names = new SortedList ();

		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;

			BuildNamesList ();
			IterateNames ();

			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);

			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		static void IterateNames()
		{
			ulong SumScores = 0;
			for (int i = 0; i < Names.Count; i++) {
				SumScores += (ulong)((int)Names.GetByIndex (i) * (i + 1));
			}

			Console.WriteLine ("Sum of the Scores: {0}", SumScores);
		}


		static int GetNameScore(string Name)
		{
			int Score = 0;

			foreach (var Letter in Name) {
				Score += ((int)Letter) - 64;
			}
			
			return Score;
		}

		static void BuildNamesList()
		{
			string[] Values;

			try
			{
				using (StreamReader sr = new StreamReader("p022_names.txt"))
				{
					string line;
					while((line = sr.ReadLine()) != null)  
					{  
						Values = line.Split(',');
						string CurrentName = string.Empty;
						int CurrentNameScore = 0;

						for (int i = 0; i < Values.Length; i++) {
							CurrentName = Values[i].Replace("\"", string.Empty);
							CurrentNameScore = GetNameScore(CurrentName);

							Names.Add(CurrentName, CurrentNameScore );
						}
					}  
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine ("Exception: {0}", ex.Message);
			}
		}
	}
}
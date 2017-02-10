using System;
using System.Collections;

namespace Problem015
{
	class MainClass
	{
		const int GridWidth = 3;
		const int GridHeight = 3;

		static int NumPaths;

		static ArrayList Paths;

		static int SleepTime = 100;

		static DateTime start;

		public static void Main (string[] args)
		{
			start = DateTime.Now;
			Console.WriteLine ("Possible Paths - {0}", Combination (40, 20));
			Console.WriteLine ("Elapsed: {0}", DateTime.Now - start);
			return;


			SleepTime = int.Parse(args [0]);

			NumPaths = (int)Combination ((long)GridWidth + (long)GridHeight, (long)GridHeight);

			Paths = new ArrayList ();
			string Path = string.Empty;
			string[] Check;

			do {
				Path = SolveGrid ();

				Check = Path.Split('>');
				if( Check.Length > GridWidth+1){
					Console.WriteLine("rejected");
					continue;
				}

				Check = Path.Split('v');
				if( Check.Length > GridHeight+1){
					Console.WriteLine("rejected");
					continue;
				}


				bool NewPath = true;

				foreach (string OldPath in Paths) {
					if (string.Compare (OldPath, Path) == 0){
						NewPath = false;
						break;
					}
				}

				if (NewPath){
					Paths.Add (Path);
					System.Media.SystemSounds.Beep.Play();
					Console.WriteLine("ACCEPTED - {0} remaining.", NumPaths - Paths.Count);
				}
				else
				{
					Console.WriteLine("duplicate");
				}
					
			} while (Paths.Count != NumPaths);

			PrintPaths ();

			Console.Beep ();
			Console.WriteLine ("Elapsed: {0}", DateTime.Now - start);
		}

		static string SolveGrid()
		{
			string Path = string.Empty;

			for (int i = 0; i < GridWidth * 2; i++) {
				Path += ProposePath();
				System.Threading.Thread.Sleep (SleepTime);				
			}

			Console.Write ("{3} - {0,3}/{1,3} Sug.Path: {2} - ", Paths.Count, NumPaths, Path, DateTime.Now - start);
			return Path;
		}

		static string ProposePath()
		{
			int Path = -1;
			Random r = new Random ();
			Path = r.Next (0, 2);
			r = null;

			if (Path == 0)
				return ">";
			else
				return "v";
		}

		static void PrintPaths (){

			foreach (string Path in Paths) {
				Console.WriteLine (Path);
			}

			Console.WriteLine ("Total Paths: {0}", Paths.Count);

		}

		public static long Combination(long n, long k)
		{
			double sum = 0;
			for (long i = 0; i < k; i++) {
				sum += Math.Log10 (n - i);
				sum -= Math.Log10 (i + 1);
			}
			return (long)Math.Pow (10, sum);
		}
	}
}
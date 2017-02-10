using System;
using System.IO;

namespace Problem018
{
	class MainClass
	{
		static int[][] Triangle = new int[15][];
		static int Sum = 0;
		
		public static void Main (string[] args)
		{
			DateTime Start = DateTime.Now;

			ReadProblem ();
			Iterate (75, 0, 0);

			Console.WriteLine ("Sum: {0}", Sum);
			Console.WriteLine ("Elapsed: {0}", DateTime.Now - Start);
		}

		static void Iterate(int Value, int LineNum, int Index )
		{
			Console.WriteLine ("Value: {0}", Value);
			Sum += Value;
			if (LineNum >= Triangle.GetLength (0) - 1)
				return;

			int Alternative1 = 0, Alternative2 = 0;

			Alternative1 = Triangle [LineNum + 1] [Index];
			Alternative2 = Triangle [LineNum + 1] [Index + 1];

			if (Alternative1 > Alternative2) {
				Iterate (Alternative1, LineNum + 1, Index);
			} else {
				Iterate (Alternative2, LineNum + 1, Index + 1);
			}
		}

		static void ReadProblem()
		{
			string[] Values;
			int[] Current;
			try
			{   // Open the text file using a stream reader.
				using (StreamReader sr = new StreamReader("Problem018.txt"))
				{

					int counter = 0;  
					string line;  

					// Read the file and display it line by line.  

					while((line = sr.ReadLine()) != null)  
					{  
						Values = line.Split(' ');
						Current = new int[Values.Length];

						for (int i = 0; i < Values.Length; i++) {
							Current[i] = int.Parse(Values[i]);
						}

						Triangle[counter] = Current;

						System.Console.WriteLine (line);  
						counter++;  
					}  

					// Read the stream to a string, and write the string to the console.
					Console.WriteLine(line);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
			}
		}
	}
}
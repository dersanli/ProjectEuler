using System;
using System.IO;
using System.Collections.Generic;

namespace Problem018
{
	class MainClass
	{
        static List<int[]> Triangle = new List<int[]>();
		
		public static void Main (string[] args)
        {
            DateTime Start = DateTime.Now;

            ReadProblem ();

            Iterate (Triangle.Count - 1);
            //PrintMaximums();

            Console.WriteLine ("Sum: {0}",Triangle[0][0]);
            Console.WriteLine ("\nElapsed: {0}", DateTime.Now - Start);
        }

        static void Iterate(int LineNum)
        {
            if (0 == LineNum)
                return;

            // 0 based. It is 14 for the 15th line.
            // Get the previous line:
            int[] BeforeLine = Triangle [LineNum - 1];

            int Value = 0;
            int Alternative1 = 0, Alternative2 = 0;

            for (int i = 0; i < BeforeLine.Length; i++) {
                Value = BeforeLine [i];
                Alternative1 = Triangle [LineNum] [i];
                Alternative2 = Triangle [LineNum] [i + 1];

                if (Alternative1 > Alternative2) {
                    Value += Alternative1;
                
                } else {
                    Value += Alternative2;
                }

                Triangle [LineNum - 1] [i] = Value;
            }

            Triangle.RemoveAt (LineNum);
            Iterate (LineNum - 1);
        }

		static void ReadProblem()
		{
			string[] Values;
			int[] Current;
			try
            {
				using (StreamReader sr = new StreamReader("Problem018.txt"))
				{
                    string line;
					while((line = sr.ReadLine()) != null)  
					{  
						Values = line.Split(' ');
						Current = new int[Values.Length];
						for (int i = 0; i < Values.Length; i++) {
							Current[i] = int.Parse(Values[i]);
						}
                        Triangle.Add( Current);
					}  
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
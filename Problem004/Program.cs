using System;

namespace Problem004
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool IsPalindrome = false;
			ulong LargestSum = 0, FirstNumber = 0, SecondNumber = 0;
			
			for (ulong i = 999; i > 0; i--) {
				for (ulong j = 999; j > 0; j--) {
					IsPalindrome = CheckPalindrome(i * j);
					Console.WriteLine("Palindrome {0}, {1} : {2}", i, j, IsPalindrome);
					if (IsPalindrome)
					{
						ulong CurrentSum = i * j;
						if ( CurrentSum > LargestSum)
						{
							LargestSum = CurrentSum;
							FirstNumber = i;
							SecondNumber = j;
						}
					}
				}
			}
			
			
			Console.WriteLine( "The Largest Sum is: {0} = {1} x {2}", LargestSum, FirstNumber, SecondNumber );
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		static bool CheckPalindrome(ulong Number)
		{
			ulong r, sum = 0, temp;    
			ulong n = Number;//It is the number variable to be checked for palindrome  
			temp = n;
			
			while (n > 0) {    
				r = n % 10;  //getting remainder  
				sum = (sum * 10) + r;    
				n = n / 10;    
			}
			
			return (temp == sum);
		}
	}
}
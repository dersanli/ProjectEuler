/*
 * Created by SharpDevelop.
 * User: dersanli
 * Date: 2/13/2017
 * Time: 2:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Problem003
{
	class Program
	{
		public static void Main(string[] args)
		{
			const ulong n = 600851475143;
    		primeFactors(n);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		// A function to print all prime factors of a given number n
		static void primeFactors(ulong n)
		{
		    // Print the number of 2s that divide n
		    while (n%2 == 0)
		    {
		        Console.Write("{0} ", 2);
		        n = n/2;
		    }
		 
		    // n must be odd at this point.  So we can skip one element (Note i = i +2)
		    for (ulong i = 3; i <=  Math.Sqrt(n); i = i+2)
		    {
		        // While i divides n, print i and divide n
		        while (n%i == 0)
		        {
		            Console.Write("{0} ", i);
		            n = n/i;
		        }
		    }
		 
		    // This condition is to handle the case whien n is a prime number
		    // greater than 2
		    if (n > 2)
		         Console.Write("{0} ", n);
		}
	}
}
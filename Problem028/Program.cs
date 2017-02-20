/*
 * Created by SharpDevelop.
 * User: dersanli
 * Date: 2/20/2017
 * Time: 4:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Problem028
{
	class Program
	{
		public static void Main(string[] args)
		{
			DateTime Start = DateTime.Now;
	
		
			
			Console.WriteLine("Elapsed: {0}", DateTime.Now - Start);
			System.Media.SystemSounds.Beep.Play();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
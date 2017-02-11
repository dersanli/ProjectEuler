using System;
using System.Numerics;

namespace Problem020
{
    /*
        n! means n × (n − 1) × ... × 3 × 2 × 1

        For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
        and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

        Find the sum of the digits in the number 100!
    */

    class MainClass
    {
        public static void Main (string[] args)
        {
            DateTime Start = DateTime.Now;

            BigInteger Number = 100;
            BigInteger Factorial = 0;

            Factorial = FactorialOf (Number);

            Console.WriteLine ("{0,4}! = {1,16}", Number, Factorial);

            string FactorialString = Factorial.ToString ();

            uint FactorialSum = 0;
            uint Current = 0;

            foreach (var item in FactorialString) {
                Current = uint.Parse (item.ToString ());
                if (0 != Current)
                    FactorialSum += Current;
            }

            Console.WriteLine ("Factorial Sum: {0}", FactorialSum);

            Console.WriteLine ("\nElapsed: {0}", DateTime.Now - Start);
        }

        static BigInteger FactorialOf(BigInteger Number)
        {
            if (Number >= 1)
                return Number * FactorialOf (Number - 1);
            else
                return 1;
        }
    }
}

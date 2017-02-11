using System;

namespace Problem019
{
    /*
        You are given the following information, but you may prefer to do some research for yourself.

            1 Jan 1900 was a Monday.
            Thirty days has September,
            April, June and November.
            All the rest have thirty-one,
            Saving February alone,
            Which has twenty-eight, rain or shine.
            And on leap years, twenty-nine.
            A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.

        How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    */

    class MainClass
    {
        public static void Main (string[] args)
        {
            DateTime Start = DateTime.Now;

            DateTime ProblemStart = new DateTime (1901, 1, 1);
            DateTime ProblemEnd = new DateTime (2000, 12, 31);

            uint SundayCount = 0;

            for (DateTime i = ProblemStart; i <= ProblemEnd; i = i.AddDays (1)) {
                if (i.Day == 1) {
                    if (i.DayOfWeek == DayOfWeek.Sunday) {
                        SundayCount++;
                    }
                }
            }

            Console.WriteLine ("Sunday Count: {0}", SundayCount);
            Console.WriteLine ("\nElapsed: {0}", DateTime.Now - Start);
        }
    }
}

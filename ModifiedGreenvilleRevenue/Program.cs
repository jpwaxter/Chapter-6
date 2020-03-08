using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedGreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            double contestantsNow = 0.0, contestantsLast = 0.0, rev = 0.0;
            string contestantsNowInput, contestantsLastInput;

            Console.Write("How many contestants entered this year? [0-30]: ");
            contestantsNowInput = Console.ReadLine();
            contestantsNow = Convert.ToDouble(contestantsNowInput);

            while (contestantsNow < 0 || contestantsNow > 30)
            {
                Console.WriteLine();
                Console.WriteLine("That number isn't between 0 and 30.");
                Console.Write("How many contestants entered this year? [0-30]: ");
                contestantsNowInput = Console.ReadLine();
                contestantsNow = Convert.ToDouble(contestantsNowInput);
                Console.WriteLine();
            }

            // grab user input for contestantsLast here
            Console.Write("How many contestants entered last year? [0-30]: ");
            contestantsLastInput = Console.ReadLine();
            contestantsLast = Convert.ToDouble(contestantsLastInput);

            while (contestantsLast < 0 || contestantsLast > 30)
            {
                Console.WriteLine();
                Console.WriteLine("That number isn't between 0 and 30.");
                Console.Write("How many contestants entered last year? [0-30]: ");
                contestantsLastInput = Console.ReadLine();
                contestantsLast = Convert.ToDouble(contestantsLastInput);
                Console.WriteLine();
            }

            rev = contestantsNow * 25;
            Console.WriteLine("This Year's Revenue: " + rev.ToString("C2"));

            // Twice as big
            if (contestantsNow > 2 * contestantsLast)
                Console.WriteLine("The competition is more than twice as big this year!");
            // Bigger but not twice as big (<= in case if contestantsNow == 2 * contestantsLast)
            else if (contestantsNow > contestantsLast && contestantsNow <= contestantsLast * 2)
                Console.WriteLine("The competition is bigger than ever!");
            // Smaller (or equal to) last year's
            else if (contestantsNow < contestantsLast)
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
            Console.ReadLine();
        }
    }
}

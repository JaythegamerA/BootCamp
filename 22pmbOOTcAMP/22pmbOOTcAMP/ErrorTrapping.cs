using System;
using System.Collections.Generic;
using System.Text;

namespace _22pmbOOTcAMP
{
   public static class ErrorTrapping
    {
        public static void Crash()
        {
            Console.WriteLine("divide by zero Error");
            int numerator = 10;
            for (int d = -3; d <= 3; d++)
            {
                int answer = numerator / d;
                Console.WriteLine("{0}/{1}= {2}", numerator, d, answer);
            }
        }

        public static void SafeCrash()
        {
            try
            {
                Console.WriteLine("divide by zero Error");
                int numerator = 10;
                for (int d = -3; d <= 3; d++)
                {
                    int answer = numerator / d;
                    Console.WriteLine("{0}/{1}= {2}", numerator, d, answer);
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("we caught the promble ");
                Console.WriteLine(error.Message);
            }
        }

    }
}

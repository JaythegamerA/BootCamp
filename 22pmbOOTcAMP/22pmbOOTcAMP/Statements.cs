using System;
using System.Collections.Generic;
using System.Text;

namespace _22pmbOOTcAMP
{
    public static class Statements
    {
        public static void BranchingIf()
        {
            int a = 7;
            if(a<4)
            {
                Console.WriteLine("Items is less than 4");
                Console.WriteLine("get more items");
            }else if (a >= 4 && a <= 10)
            {
                Console.WriteLine("items are between 4 & 10 (inclusive)");
            }
            else
            {
                Console.WriteLine("items are greater than ten ");
            }

            int b = 10;
            if (b > 5) Console.WriteLine("Atack is greater than ten");

        } 
        public static void Switching()
        {
            int d = 8 % 7;
            string day = "";
            
            switch(d)
            {
                case 1:
                    day = "monday";
                    break;
                case 2:
                    day = "tuseday";
                    break;
                case 3:
                    day = "wednsday";
                    break;
                case 4:
                    day = "thrusday";
                    break;
                case 5:
                    day = "friday";
                    break;
                default:
                    day = "weekend";
                    break;

            }
            Console.WriteLine("day {0} is {1}", d, day);
        }

        public static void ForLoop()
        {
           
            for(int i=1; i<=15; i++)
            {
                Console.WriteLine("the value of mp is {0}", i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("outer level {0}", i);

                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\tinner level {0}", j);
                }
            }
        }

        public static void Whileloops()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("the value of i is {0}", i);
                i++;
            }

            int j = 0;
            do
            {
                Console.WriteLine("the value of j is {0}", j);
                j++;
            } while (j < 5);

            do
            {
                Console.Write("enter command: > ");

            } while (Console.ReadLine() != "q");
        }

        public static void LoopingArrays()
        {
            string[] monster = new string[4];
            monster[0] = "fred the foe";
            monster[1] = "thomas the terrible";
            monster[2] = "logan the lacerator";
            monster[3] = "ron the ravenous";

            Console.WriteLine("monster list");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t{0}", monster[i]);
            }
        }

        public static void ForEachIterations()
        {
            List<string> phones = new List<string>();
            phones.Add("iphone 12");
            phones.Add("google pixel");
            phones.Add("motorla stylus");
            phones.Add("nokia flip phone");
            phones.Add("one pluse");
            Console.WriteLine("list of phones in our inventory:");

            foreach(string p in phones)
            {
                Console.WriteLine("\t{0}", p);
            }
        }
    }
}

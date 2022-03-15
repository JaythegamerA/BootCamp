using System;
using System.Collections.Generic;
using System.Text;

namespace _22pmbOOTcAMP
{
   public static class Storing // you can not make Objects
    {

        enum Days { sunday, Monday, Tuesday, Wednsday, Thursday, Friday, Saturday };

        //Methods
        public static void DemoVariables()
        {
            int PlayerID = 444;
            uint playerHealth = 555;
            ulong PlayerCoordinates = 477282739847;
            float pi = 3.14159f;
            Console.WriteLine(pi);
            bool PlayerIsRich = true;
            string playerName = "Jonathan";

            char firstInitial = 'j';
            
           // firstInitial--;
            Console.WriteLine(firstInitial);
            
            char beep = (char)7;
            Console.WriteLine(beep);
            while(true)
            {
                Console.WriteLine(beep);
                beep++;
                Console.WriteLine();
            }

        }


        public static void ReadingInput()
        {
            Console.Write(" Enter Your Name Player > ");
            String name = Console.ReadLine();
            Console.WriteLine(" Hello ,{0}. It is good to have you in the new world", name);
            Console.WriteLine(" enter Your age: > ");
            int age = Convert.ToInt32(Console.ReadLine());
            int ageInMonths = age * 12;
            Console.WriteLine("thank you. you are {0} months old!", ageInMonths);


        }

        public static void UsingArrays()
        {
            String[] enemyName = new string[5];
            enemyName[0] = "Rilley the Ravesnous";
            enemyName[1] = "joseph the Joker";
            enemyName[2] = "Joseph the Jugular";
            enemyName[3] = "ron the Raptor";
            enemyName[4] = "nayhan the Nasty";

            int[] enemyHealth = new int [5] { 10, 30, 35, 2, 90 };
            System.Random random = new System.Random();
            while (true)
            {
                int num = random.Next(5);
                Console.WriteLine("Rolled a {0}", num);
                enemyHealth[num]--;
                Console.WriteLine("{0} raisd an axe and swung and now has {1} health", enemyName[num], enemyHealth[num]);
                Console.ReadLine();

            }

        }

        public static void ConstantsAndEnums()
        {
            const double PI = 3.1415926535;
            Console.WriteLine(PI);

            var dayOfweek = Days.Tuesday;
            if(dayOfweek == Days.Saturday || dayOfweek == Days.sunday)
            {
                Console.WriteLine("Weekend");
            }else
            {
                Console.WriteLine("Workday");
            }

        }

    }
}

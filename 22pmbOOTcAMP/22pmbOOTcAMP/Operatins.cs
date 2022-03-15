using System;
using System.Collections.Generic;
using System.Text;

namespace _22pmbOOTcAMP
{
    class Operatins
    {
        public static void Arethmetic()
        {
            int a = 9;
            int b = 6;
            int c;

            a++;
            b--;

            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            c = a % b;

            a += b;
            a -= b;
            a *= b;
            a /= b;

            //a = 10;
            a /= 7;


        }

        public static void Comparison()
        {
            int a = 10;
            int b = 42;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
        }

        public static void Logic()
        {
            bool hasSword = true;
            bool hasMagic = false;

            if (hasMagic) Console.WriteLine("Has a magic amulet");
            if (!hasMagic) Console.WriteLine("Dose not magic amulet");
            if (hasMagic && hasSword) Console.WriteLine("Very dangerous .. has both magic and sword");
            if (hasMagic || hasSword) Console.WriteLine("can attack with magic or sword");
            if (hasMagic ^ hasSword) Console.WriteLine("only has one form of attack");
            if (!hasSword && hasMagic) Console.WriteLine("run you dont any form of attack");

        }

        public static void Ternary()
        {
            int a = 18;
            int b = 42;
            int c;

            c = (a == b) ? a : b;
            Console.WriteLine(c);

            string Answer = (a % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(Answer);
            Console.WriteLine("{0} is {1}", a, Answer);

        }

    }
}

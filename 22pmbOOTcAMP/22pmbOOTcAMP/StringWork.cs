using System;
using System.Collections.Generic;
using System.Text;

namespace _22pmbOOTcAMP
{
   public static class StringWork
    {

        public static void StringFeatures()
        {
            Console.WriteLine("enter text");
            string  text = Console.ReadLine().Trim();
            if(String.IsNullOrEmpty(text))
            {
                Console.WriteLine("i told you to enter text");

            }else
            {
                Console.WriteLine("tnank. you entered \" {0}\"", text);
                string query = text.StartsWith("C#") ? "dose" : "dose not";
                Console.WriteLine("'{0}'{1} start with C# ", text, query);
                query = text.EndsWith("cool") ? "dose" : "dose not";
                Console.WriteLine("'{0}' {1} ends with cool. ", text, query);
            }
        }

        public static void Maipulate()
        {
            Console.WriteLine("enter text");
            string text = Console.ReadLine();
            Console.WriteLine("tnank. you entered \" {0}\"", text);
            Console.WriteLine("your text is {0} long.", text.Length);
            text = text.Trim();
            Console.WriteLine("your trimmed text is {0} long. ", text.Length);
            string upper = text.ToUpper();
            string lower = text.ToLower();
            Console.WriteLine(upper);
            Console.WriteLine(lower);
            string huh = text.ToLowerInvariant();
            Console.WriteLine(huh);
            text = text.PadLeft(15, '*');
            text = text.PadRight(30, '*');
            Console.WriteLine(text);


        }

        public static void JoinAndCompare()
        {
            string[] a = new string[3] { "apha", "beta", "gamma" };
            string s = string.Concat(a[0], a[2]);
            Console.WriteLine(s);
            s = a[0] + a[1];
            Console.WriteLine(s);
            s = string.Join(" ", a[0], a[1], a[2]);
            Console.WriteLine(s);
            s = string.Join(" ", a);
            Console.WriteLine(s);

            int num = string.Compare("apples", "Oranges");
            Console.WriteLine(num);

            Console.WriteLine("apples" == "Oranges");

        }

        public static void SubString()
        {
            string phrase = "the quick fox jumped over the lazy dog and cat and the mouse.".ToLower();
            string searchTerm = "lazy";
            int num = phrase.IndexOf(searchTerm,0);
            Console.WriteLine(num);
        }

        public static void Formatting()
        {
            float number = 2.567f;
            string sN = number.ToString("00000000000.00000000");
            Console.WriteLine(sN);

            string data = "apha,bravo,charlie,delta,echo,foxtrot";
            string data2 = "this is a long sentence that i am writing";
            string[] items = data.Split(',');
            string[] items2 = data2.Split(' ');
            //Console.WriteLine(items[3]);
            foreach (string item in items2)
            {
                Console.WriteLine(item);
            }
        }

        public static void DateString()
        {

            DateTime now = DateTime.Now;
            //Console.WriteLine(now);
            //Console.WriteLine(now.DayOfWeek);
            //Console.WriteLine(now.DayOfYear);
            //Console.WriteLine(Convert.ToString(now.ToBinary(),2));

            DateTime birthday = new DateTime(2003, 10, 26);
            Console.WriteLine(birthday.DayOfWeek);
            Console.WriteLine(birthday.AddYears(51).DayOfWeek);
        }

    }
}

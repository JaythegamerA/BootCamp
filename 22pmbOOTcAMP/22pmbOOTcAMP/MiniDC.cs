using System;
using System.Collections.Generic;
using System.Text;

namespace _22pmbOOTcAMP
{
    public static class MiniDC
    {

        //Method
        public static void StartDC()
        {
            Console.Clear();
            Console.WriteLine("Mini Dungeon Crawler. Welcome to D'nal!");
            Console.Write("\n\tWhat is your name, dear player? >");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 40);

            //Create some monsters...
            Player[] monster = new Player[6];
            monster[0] = new Player(0, "", 0);
            monster[1] = new Player(1, "Goblo the Giant" , 25);
            monster[2] = new Player(2, "The Wizard of D'nal" , 5);
            monster[3] = new Player(3, "Landon the Lancer" , 15);
            monster[4] = new Player(4, "Griffin the Gryfin" , 20);
            monster[5] = new Player(5, "Greg" , 125);

            //Create some locations
            int maxX = 11;
            int maxY = 11;
            //create a 2D array of locations
            Location[,] location = new Location[maxX, maxY];  //make lots of null locations

            location[5, 5] = new Location("Home", "You sit in a comfy chair near a fire.", 0);
            location[4, 4] = new Location("Getel", "A small town with a magical fountain.", 2);
            location[7, 7] = new Location("A Huge Cavern", "You hear rumbling and stomping sounds.", 5);
            location[9, 7] = new Location("A Weeping Willow", "The branches of the willow sooth you.", 0);


            //Place the player at home
            int pX = 5;
            int pY = 5;

            //Create a dice to roll...
            Random dice = new Random();

            while(true)
            {
                Console.WriteLine("\n----------------------");
                Console.WriteLine("Health: {0}", player.Health);
                Console.WriteLine("Location: {0},{1} ", pX, pY);

                if (location[pX, pY] != null)
                {
                    Console.WriteLine("*** {0} *** ", location[pX, pY].LocationName);
                    Console.WriteLine("*** {0} *** ", location[pX, pY].Description);

                    if(location[pX,pY].MonsterID != 0)
                    {
                        int mID = location[pX, pY].MonsterID;
                        Console.WriteLine("!!! {0} with health of {1} !!! ", monster[mID].Name, monster[mID].Health);

                        int damageToPlayer = dice.Next(1, 8);
                        int damageToMonster = dice.Next(1, 8);

                        player.Health -= damageToPlayer;
                        monster[mID].Health -= damageToMonster;

                        Console.WriteLine("you take {0} damage and your health is {1} ", damageToPlayer, player.Health);
                        Console.WriteLine("monster take {0} damage and monster's health is {1}", damageToMonster, monster[mID].Health);

                        if(player.Health<=0)
                        {
                            Console.WriteLine("i'am sorry you died come back next time");
                            return;
                        }
                        if(monster[mID].Health<=0)
                        {
                            Console.WriteLine("you killed {0}", monster[mID].Name);
                            location[pX, pY].MonsterID = 0;
                            location[pX, pY] = null;
                        }
                    }
                }


                if (pX == 9 && pY == 7)
                {
                    Console.WriteLine("you feel better ");
                    player.Health += dice.Next(1, 4);
                    if (player.Health > 60) player.Health = 60;
                    Console.WriteLine("your health is now {0}", player.Health);

                }

                Console.Write("Your wish is my Command >");
                string cmd = Console.ReadLine().ToLower().Trim();
                if (cmd == "q" || cmd == "quit" )
                        {
                    Console.WriteLine("thank you for Playing");
                        }
                if (cmd == "n") pY--;
                if (cmd == "s") pY--;
                if (cmd == "e") pX--;
                if (cmd == "w") pX--;

                pX = Math.Clamp(pX, 0, maxX - 1);
                if (pY < 0) pY = maxY-1;
                if (pY > maxY-1) pY = 0;

                if (cmd == "m") Location.DrawMap(location, pX, pY);

                try
                {

                    if (cmd == "save") DataManagment.SavePlayerData(player);
                }
                catch
                {
                    Console.WriteLine("Could not save player Data");
                }
                try
                {
                    if (cmd == "load") player = DataManagment.LoadPlayerData(player);
                }
                catch
                {
                    Console.WriteLine("Could not restore data");
                }
            }

        }


    }
}

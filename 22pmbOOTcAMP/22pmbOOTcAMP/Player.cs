using System;
using System.Collections.Generic;
using System.Text;

namespace _22pmbOOTcAMP
{
    public class Player
    {
        //Properties
        public int ID { get; set; } //0 is the real player.  1,2,3... are for monsters, NPCs, etc
        public string Name { get; set; }
        public int Health { get; set; }

        public Player() { }

        public Player(int iD, string name, int health)
        {
            ID = iD;
            Name = name;
            Health = health;
        }
    }
}

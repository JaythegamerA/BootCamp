using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace _22pmbOOTcAMP
{
   public static class DataManagment
    {

        public static void SavePlayerData(Player p)
        {
            string jsp = JsonSerializer.Serialize(p);
            Console.WriteLine("serializing {0}", jsp);
            string fileName = "e:\\vgd\\PmPlayerData.txt";
            File.WriteAllText(fileName, jsp);
            Console.WriteLine("Player data saved");
        }

        public static Player LoadPlayerData(Player p)
        {
            string fileName = "e:\\vgd\\PmPlayerData.txt";
            string jsp = File.ReadAllText(fileName);
            Player x = JsonSerializer.Deserialize<Player>(jsp);
            Console.WriteLine("player loaded");
            return x;
        }
    }
}

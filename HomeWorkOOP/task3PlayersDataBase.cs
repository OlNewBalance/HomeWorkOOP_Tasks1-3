using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace OOP
{
    public class PlayerBase
    {
        public string PlayerName { get; set; }
        public int UnicId { get; set; }
        public int PlayerLevel { get; set; }
        public bool BanFlag { get; set; }
        public static string Name { get; }

        public static bool banFlag { get; set; }


        public PlayerBase(string playerName, int unicId, int playerLevel, bool banFlag)
        {
            this.PlayerName = playerName;
            this.UnicId = unicId;
            this.PlayerLevel = playerLevel;
            this.BanFlag = banFlag;
        }
        
    }
     public class DataBase
     {
         private Dictionary<int, PlayerBase> _players = new Dictionary<int, PlayerBase>() { };
         public void AddPlayer(string name, int unicId, int level, bool banFlag = false)
         {
             if (_players.ContainsKey(level))
             {
                 Console.WriteLine($"Player {name} is already added");
             }

             _players.Add(unicId, new PlayerBase(name, unicId, level, banFlag));
         }

         public void BanPlayer(int unicId)
         {
             if (_players.TryGetValue(unicId, out PlayerBase player))
             {
                 PlayerBase.banFlag = true;
                 Console.WriteLine($"Игрок {PlayerBase.Name} забанен.");
             }
             else
             {
                 Console.WriteLine($"Игрок с ID {unicId} не найден!");
             }
         }

         public void UnBanPlayer(int unicId)
         {
             if (_players.TryGetValue(unicId, out PlayerBase player))
             {
                 PlayerBase.banFlag = false;
                 Console.WriteLine($"Игрок {PlayerBase.Name} разбанен.");
             }
             else
             {
                 Console.WriteLine($"Игрок с ID {unicId} не найден!");
             }
         }

         public void DeletePlayer(int unicId)
         {
             if (_players.Remove(unicId, out PlayerBase player))
             {
                 Console.WriteLine($"Игрок {PlayerBase.Name} удален.");
             }
             else
             {
                 Console.WriteLine($"Игрок с ID {unicId} не найден!");
             }
         }

         public void PrintPlayers()
         {
             foreach (var player in _players.Values)
             {
                 Console.WriteLine($"ID: {player.UnicId}, Ник: {player.PlayerName}, Уровень: {player.PlayerLevel}, Бан: {player.BanFlag}");
             }
         }
     }
    
    public class PlayerStatisticVisor
    {
        
    }
}

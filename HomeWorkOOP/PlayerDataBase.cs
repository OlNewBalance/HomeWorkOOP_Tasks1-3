using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace OOP
{
    public class DataBase
    {
        private Dictionary<int, Player> _players = new Dictionary<int, Player>();

        public void AddPlayer(string name, int unicId, int level, bool banFlag = false)
        {
            if (_players.ContainsKey(unicId))
            {
                Console.WriteLine($"Player {name} is already added");
            }

            _players.Add(unicId, new Player("Victor", 24, 100, 100, 12,
                12, false, 56));
        }

        public void BanPlayer(int unicId)
        {
            if (_players.TryGetValue(unicId, out Player player))
            {
                player.BanFlag = true;
                Console.WriteLine($"Игрок {player.Name} забанен.");
            }
            else
            {
                Console.WriteLine($"Игрок с ID {unicId} не найден!");
            }
        }

        public void UnBanPlayer(int unicId)
        {
            if (_players.TryGetValue(unicId, out Player player))
            {
                player.BanFlag = false;
                Console.WriteLine($"Игрок {player.Name} разбанен.");
            }
            else
            {
                Console.WriteLine($"Игрок с ID {unicId} не найден!");
            }
        }

        public void DeletePlayer(int unicId)
        {
            if (_players.Remove(unicId, out Player player))
            {
                Console.WriteLine($"Игрок {player.Name} удален.");
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
                Console.WriteLine(
                    $"ID: {player.UnicId}, Ник: {player.Name}, Уровень: {player.Level}, Бан: {player.BanFlag}," +
                    $"Скорость ходьбы: {player.SpeedOfWalk}, Возраст: {player.Age}, Здоровье: {player.Health}, " +
                    $"Стамина: {player.Stamina}");
            }
        }
    }
}

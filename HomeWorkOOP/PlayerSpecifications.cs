namespace OOP
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int SpeedOfWalk { get; set; }

        public int Level { get; set; }

        internal readonly int UnicId;

        public bool BanFlag { get; set; }

        public Player(string name, int age, int health, int stamina, int speedOfWalk, int unicId, bool banFlag,
            int level)
        {
            Name = name;
            Age = age;
            Health = health;
            Stamina = stamina;
            SpeedOfWalk = speedOfWalk;
            UnicId = unicId;
            BanFlag = banFlag;
            Level = level;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Stamina: {Stamina}");
            Console.WriteLine($"Speed: {SpeedOfWalk}");
        }
    }

    public class PlayerPosition
    {
        public static double VectorX { get; set; }
        public static double VectorY { get; set; }

        public PlayerPosition(double x, double y)
        {
            VectorX = x;
            VectorY = y;
        }

        public static void PlayerRender()
        {
            Console.WriteLine($"X = {VectorX} : Y = {VectorY}");
        }
    }
}

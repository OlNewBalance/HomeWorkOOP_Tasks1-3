namespace OOP
{
    internal class Program
    {
        static public void Main()
        {
            Random random = new Random();
            Player a = new GameCharacter("Harris", random.Next(16, 80), 100, 100, 
                random.Next(1, 100), random.Next(1, 100), random.Next(1, 2) == 1 ? true : false,
                random.Next(0, 100));
            a.PrintInformation();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Player playerVasiliy = new Player("Vasiliy", 24, 100, 100, 12,
                random.Next(1, 100), random.Next(1, 2) == 1 ? true : false,
                random.Next(0, 100));
            PlayerPosition postition = new PlayerPosition(random.Next(100), random.Next(100));
            PlayerPosition.PlayerRender();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            var db = new DataBase();
            db.AddPlayer("Finkton", 1, 140, false);
            db.AddPlayer("Waljenuje", 2, 140, false);
            db.AddPlayer("CanOfPiss", 3, 140, false);
            db.AddPlayer("Kristina", 4, 140, false);
            db.BanPlayer(4);
            db.UnBanPlayer(2);
            db.DeletePlayer(3);
            db.PrintPlayers();
        }
    }
}

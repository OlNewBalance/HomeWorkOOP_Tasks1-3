namespace OOP
{
internal class Program
{
    static public void Main()
    {
        Random random = new Random();
        Human a = new GameCharacter("Harris", random.Next(16, 80), 100, 100, random.Next(1, 100));
        a.Printinformation();
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Player player = new Player(random.Next(100), random.Next(100));
        Renderer rend = new Renderer();
        Renderer.RenderPlayer(player);
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        var db = new DataBase();
        db.AddPlayer("Finkton", 1, 140,false);
        db.AddPlayer("Waljenuje", 2, 140,false);
        db.AddPlayer("CanOfPiss", 3, 140,false);
        db.AddPlayer("Kristina", 4, 140,false);
        db.BanPlayer(4);
        db.UnBanPlayer(2);
        db.DeletePlayer(3);
        db.PrintPlayers();
    }
}
}

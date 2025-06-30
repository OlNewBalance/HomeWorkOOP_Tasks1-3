namespace OOP
{
    public class Player
    {
        public double Xcor { get; set; }
        public double Ycor { get; set; }

        public Player(double x, double y)
        {
            this.Xcor = x;
            this.Ycor = y;
        }
    }

    public class Renderer
    {
        public static void RenderPlayer(Player player)
        {
            Console.WriteLine($"X = {player.Xcor} : Y = {player.Ycor}");
        }
    }
}

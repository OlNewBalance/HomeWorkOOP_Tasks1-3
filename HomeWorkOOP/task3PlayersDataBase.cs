namespace OOP
{
    public class GameCharacter : Player
    {
        public GameCharacter(string name, int age, int health, int stamina, int speedOfWalk, int unicId,
            bool banFlag, int level) :
            base(name, age, health, stamina, speedOfWalk, unicId, banFlag, level)
        {
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Name - {Name}, age - {Age}, stamina - {Stamina}, speed of walking - {SpeedOfWalk}," +
                              $" health - {Health}");
        }
    }
}

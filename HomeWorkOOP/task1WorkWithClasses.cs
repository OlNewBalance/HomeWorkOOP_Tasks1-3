namespace OOP
{
    abstract class Human
    {
        public string Name;
        public int Age;
        public int Health;
        public int Stamina;
        public int SpeedOfWalk;

        public Human(string name, int age, int health, int stamina, int speedOfWalk)
        {
            this.Name = name;
            this.Age = age;
            this.Health = health;
            this.Stamina = stamina;
            this.SpeedOfWalk = speedOfWalk;

        }

        public abstract void Printinformation();
    }

    class GameCharacter : Human
    {
        public GameCharacter(string name, int age, int health, int stamina, int speedOfWalk) : base(name, age, health, stamina, speedOfWalk)
        {}
        public override void Printinformation()
        {
            Console.WriteLine($"Name - {this.Name}, age - {this.Age}, stamina - {this.Stamina}, speed of walking - {this.SpeedOfWalk}, health - {this.Health}");
        }
    }
}

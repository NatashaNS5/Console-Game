

namespace ConsoleApp1;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello World!");
    }
    public class Personage
    {
        public string Name { get; set; }
        public uint Health { get; set; }
        public uint CurrentHealth { get; set; }
        public int Strong { get; set; }
        public int Protection { get; set; }
        public uint Level { get; set; }
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }

        public Personage(string name, uint health, uint currentHealth, int strong, int protection, uint level, int minAttack, int maxAttack)
        {
            Name = name;
            Health = health;
            CurrentHealth = currentHealth;
            Strong = strong;
            Protection = protection;
            Level = level;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
        }
    }

    public class Hero : Personage
    {
        public uint Exp { get; set; }

        public Hero(string name, uint health, uint currentHealth, int strong, int protection, uint level, uint exp, int minAttack, int maxAttack)
            : base(name, health, currentHealth, strong, protection, level, minAttack, maxAttack)
        {
            Exp = exp;
        }
    }

    public class Opponent : Personage
    {
        public Opponent(string name, uint health, uint currentHealth, int strong, int protection, uint level, int minAttack, int maxAttack)
            : base(name, health, currentHealth, strong, protection, level, minAttack, maxAttack)
        {

        }
    }

    public class Boss : Personage
    {
        public Boss(string name, uint health, uint currentHealth, int strong, int protection, uint level, int minAttack, int maxAttack)
            : base(name, health, currentHealth, strong, protection, level, minAttack, maxAttack)
        {

        }
    }
}
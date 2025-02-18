using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
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
}

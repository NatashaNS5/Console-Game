using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Reward
    {
        public int Exp { get; set; }
        public uint Health { get; set; }
        public int Strong { get; set; }
        public int Protection { get; set; }

        public Reward(int exp, uint health, int strong, int protection)
        {
            Exp = exp;
            Health = health;
            Strong = strong;
            Protection = protection;
        }
    }
}

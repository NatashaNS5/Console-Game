using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Level
    {
        public uint Number { get; set; }
        public string Name { get; set; }
        public List<Opponent> Opponents { get; set; }
        public Boss Boss { get; set; }
        public Reward Reward { get; set; }

        public Level(uint number, string name, List<Opponent> opponents, Boss boss, Reward reward)
        {
            Number = number;
            Name = name;
            Opponents = opponents;
            Boss = boss;
            Reward = reward;
        }
    }
}
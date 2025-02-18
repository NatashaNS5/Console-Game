using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Opponent : Personage
    {
        public Opponent(string name, uint health, uint currentHealth, int strong, int protection, uint level, int minAttack, int maxAttack)
            : base(name, health, currentHealth, strong, protection, level, minAttack, maxAttack)
        {

        }
    }
}

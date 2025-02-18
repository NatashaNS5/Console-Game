using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class User
    {
        public string Name { get; set; }
        public Hero Hero { get; set; }
        public User(string name, Hero hero)
        {
            Name = name;
            Hero = hero;
        }
    }
}

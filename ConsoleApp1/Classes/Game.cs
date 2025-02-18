using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Game
    {
        public User User { get; set; }
        public List<Level> Levels { get; set; }
        public Level? CurrentLevel { get; set; }

        public Game(User user, List<Level> levels)
        {
            User = user;
            Levels = levels;
            CurrentLevel = null;
        }
    }
}
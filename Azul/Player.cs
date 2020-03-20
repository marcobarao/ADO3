using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azul
{
    public class Player
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int score { get; set; }

        public Player() {}

        public Player(string username)
        {
            this.username = username;
        }
    }
}

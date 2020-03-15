using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azul
{
    public enum Status { ALL = 'T', OPEN = 'A', PLAYING = 'J', FINISHED = 'E' }
   

    public class Game
    {
        public int id { get; private set; }
        public string name { get; set; }
        public string password { get; set; }
        public DateTime date { get; set; }
        public Status status { get; set; }

        public Game(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Azul
{
    

    public class Game
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public DateTime date { get; set; }
        public String status { get; set; }

        public Game()
        {
            
        }

        public Game(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}

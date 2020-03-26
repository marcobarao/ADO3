using AzulServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void startGame(Game game)
        {
            string result = Jogo.IniciarPartida(this.id, this.password);

            if (result != String.Empty)
            {
                game.actualPlayer = Convert.ToInt32(result.Trim());
            }
        }
    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;


namespace Azul
{


    public class Game
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public DateTime date { get; set; }
        public String status { get; set; }

        public BindingList<Player> players = new BindingList<Player>();

        public Game() {}

        public Game(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public void listPlayers()
        {
            string result = Jogo.ListarJogadores(this.id);

            if (result != String.Empty)
            {
                result = result.Trim();
                result.Replace("\n", String.Empty);
                String[] matches = result.Split('\r');

                foreach (String match in matches)
                {
                    Player player = new Player();
                    String[] playerInfo = match.Split(',');

                    player.id = Convert.ToInt32(playerInfo[0]);
                    player.username = playerInfo[1];
                    player.score = Convert.ToInt32(playerInfo[2]);
                    this.players.Add(player);
                }
            }
        }
    }
}

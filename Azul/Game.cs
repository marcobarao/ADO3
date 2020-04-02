using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public int actualPlayer { get; set; }

        public BindingList<Player> players = new BindingList<Player>();
        public List<Factory> factories = new List<Factory>();

        public Game()
        {
            for (int i = 1; i < 10; i++)
            {
                factories.Add(new Factory(i));
            }
        }

        public Game(string name, string password)
        {
            this.name = name;
            this.password = password;

            for (int i = 1; i < 10; i++)
            {
                factories.Add(new Factory(i));
            }
        }

        public void readFactories(Player player)
        {
            string result = Jogo.LerFabricas(player.id, player.password);

            if (result != String.Empty)
            {
                result = result.Trim();
                result.Replace("\n", String.Empty);
                String[] lines = result.Split('\r');

                foreach (String line in lines)
                {
                    String[] tileInfo = line.Split(',');

                    int factoryId = Convert.ToInt32(tileInfo[1]);
                    Factory factory = this.factories.Find(item => item.id == factoryId);
                    int quantity = Convert.ToInt32(tileInfo[3]);

                    for (; quantity > 0; quantity--)
                    {
                        Tile tile = new Tile();
                        tile.id = Convert.ToInt32(tileInfo[1]);
                        tile.color = tileInfo[2];
                        factory.tiles.Add(tile);

                    }
                }
            }
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

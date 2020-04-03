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

        public BindingList<Player> players { get; set; }
        public BindingList<Factory> factories { get; set; }
        public Center center { get; set; }

        public Game()
        {
            this.players = new BindingList<Player>();
            this.factories = new BindingList<Factory>();
            this.center = new Center();
        }

        public Game(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public void readFactories(Player player)
        {
            string result = Jogo.LerFabricas(player.id, player.password);

            if (result != String.Empty && !result.StartsWith("ERRO"))
            {
                result = result.Trim();
                result.Replace("\n", String.Empty);
                String[] lines = result.Split('\r');


                foreach (String line in lines)
                {
                    String[] tileInfo = line.Split(',');

                    int factoryId = Convert.ToInt32(tileInfo[0]);
                    if (factoryId > factories.Count)
                    {
                        factories.Add(new Factory(factoryId));
                    }

                    Factory factory = this.factories.SingleOrDefault(item => item.id == factoryId);
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

        public void readCenter(Player player)
        {
            string result = Jogo.LerCentro(player.id, player.password);

            if (result != String.Empty && !result.StartsWith("ERRO"))
            {
                result = result.Trim();
                result.Replace("\n", String.Empty);
                String[] lines = result.Split('\r');


                foreach (String line in lines)
                {
                    String[] tileInfo = line.Split(',');

                    int quantity = Convert.ToInt32(tileInfo[2]);

                    for (; quantity > 0; quantity--)
                    {
                        Tile tile = new Tile();
                        tile.id = Convert.ToInt32(tileInfo[0]);
                        tile.color = tileInfo[1];
                        center.tiles.Add(tile);
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

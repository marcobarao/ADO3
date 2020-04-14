using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AzulServer;


namespace Azul
{
    public class Game
    {

        public Dictionary<int, Color> colors = new Dictionary<int, Color> {
            { 0, Color.MediumSpringGreen },
            { 1, Color.Blue },
            { 2, Color.Yellow },
            { 3, Color.Red },
            { 4, Color.Black },
            { 5, Color.White }
        };

        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public DateTime date { get; set; }
        public String status { get; set; }
        public int actualPlayer { get; set; }

        public BindingList<Player> players { get; set; }
        public BindingList<Factory> factories { get; set; }
        public List<Line> model { get; set; }

        public List<Line> wall { get; set; }
        public Line floor { get; set; }
        public Center center { get; set; }

        public Game()
        {
            this.players = new BindingList<Player>();
            this.factories = new BindingList<Factory>();
            this.model = new List<Line>();
            this.wall = new List<Line>();
            this.floor = new Line(1);
            this.center = new Center();

            for (int i = 1; i <= 5; i++)
            {
                this.model.Add(new Line(i));
                var line = new Line(i);

                for (int j = 1; j <= 5; j++)
                {
                    line.tiles.Add(new Tile(j));
                }

                this.wall.Add(line);
            }
        }

        public Game(string name, string password)
        {
            this.players = new BindingList<Player>();
            this.factories = new BindingList<Factory>();
            this.model = new List<Line>();
            this.center = new Center();
            this.wall = new List<Line>();
            this.floor = new Line(1);
            this.name = name;
            this.password = password;

            for (int i = 1; i <= 5; i++)
            {
                this.model.Add(new Line(i));
                Line line = new Line(i);

                for (int j = 1; j <= 5; j++)
                {
                    line.tiles.Add(new Tile(j));
                }

                this.wall.Add(line);
            }
        }

        public void readFactories(Player player)
        {
            string result = Jogo.LerFabricas(player.id, player.password);

            foreach (var factory in factories)
            {
                factory.tiles.Clear();
            }

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
                        tile.color = colors[tile.id];
                        factory.tiles.Add(tile);
                    }
                }
            }
        }

        public void readCenter(Player player)
        {
            string result = Jogo.LerCentro(player.id, player.password);
            this.center.tiles.Clear();

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
                        tile.color = colors[tile.id];
                        center.tiles.Add(tile);
                    }
                }
            }
        }

        public void createModel(string entity)
        {
            string transformedEntity = entity.Trim().Replace("\n", String.Empty);

            if (transformedEntity != String.Empty)
            {
                String[] lines = transformedEntity.Split('\r');

                foreach (string line in lines)
                {
                    String[] tileInfo = line.Split(',');

                    Line actualLine = model.Find(x => x.id == Convert.ToInt32(tileInfo[0]));
                    int quantity = Convert.ToInt32(tileInfo[2]);

                    actualLine.tiles.Clear();
                    for (; quantity > 0; quantity--)
                    {
                        Tile tile = new Tile();
                        tile.id = Convert.ToInt32(tileInfo[1]);
                        tile.color = colors[tile.id];
                        actualLine.tiles.Add(tile);
                    }
                }
            }
        }

        public void createWall(string entity)
        {
            string transformedEntity = entity.Trim().Replace("\n", String.Empty);

            if (transformedEntity != String.Empty)
            {
                String[] lines = transformedEntity.Split('\r');
            
                foreach (string line in lines)
                {
                    String[] tileInfo = line.Split(',');

                    Line actualLine = wall.Find(x => x.id == Convert.ToInt32(tileInfo[0]));
                    Tile actualTile = actualLine.tiles.Single(x => x.id == Convert.ToInt32(tileInfo[1]));

                    string stringId = Regex.Match(tileInfo[2], @"\d+").Value;
                    actualTile.id = Convert.ToInt32(stringId);
                    actualTile.color = colors[actualTile.id];
                }
            }
        }

        public void createFloor(string entity)
        {
            string transformedEntity = entity.Trim().Replace("\n", String.Empty);

            if (transformedEntity != String.Empty)
            {
                String[] lines = transformedEntity.Split('\r');

                this.floor.tiles.Clear();
                foreach (string line in lines)
                {
                    String[] tileInfo = line.Split(',');

                    
                    Tile tile = new Tile();
                    tile.id = Convert.ToInt32(tileInfo[1]);
                    tile.color = colors[tile.id];
                    tile.penalty = Convert.ToInt32(tileInfo[2]);
                    floor.tiles.Add(tile);
                }
            }
        }

        public void readTable(Player player, Player target)
        { 
            string result = Jogo.LerTabuleiro(player.id, player.password, target.id);

            if (result != String.Empty && !result.StartsWith("ERRO"))
            {
                String[] entity = result.Split(new [] { "modelo", "chão", "parede" }, StringSplitOptions.None);
                entity = entity.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                this.createModel(entity[0]);
                this.createWall(entity[1]);
                this.createFloor(entity[2]);
            }
        }

        public void listPlayers()
        {
            string result = Jogo.ListarJogadores(this.id);

            if (result != String.Empty && !result.StartsWith("ERRO"))
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

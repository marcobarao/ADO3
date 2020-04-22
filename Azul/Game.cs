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

        public Dictionary<int, Color> lightColors = new Dictionary<int, Color> {
            { 1, Color.FromArgb(100, 0, 0, 255) },
            { 5, Color.FromArgb(100, 200, 200, 200) },
            { 4, Color.FromArgb(100, 0, 0, 0) },
            { 3, Color.FromArgb(100, 255, 0, 0) },
            { 2, Color.FromArgb(100, 255, 255, 0) }
        };

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

        public bool yourTurn { get; set; }

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


            createLightWall();
            createEmptyModel();
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

            createLightWall();
            createEmptyModel();
        }

        public void createLightWall()
        {
            string result = Jogo.ConsultarParede();

            

            if (result != String.Empty && !result.StartsWith("ERRO"))
            {
                result = result.Trim().Replace("\n", String.Empty);
                String[] infos = result.Split('\r');
                foreach (String info in infos)
                {
                    String[] tileInfo = info.Split(',');

                    int lineId = Convert.ToInt32(tileInfo[0]);
                    int tileId = Convert.ToInt32(tileInfo[2]);
                    if (lineId > wall.Count)
                    {
                        wall.Add(new Line(lineId));
                    }

                    Line line = this.wall.SingleOrDefault(item => item.id == lineId);
                    Tile tile = new Tile(tileId);
                    tile.color = lightColors[tile.id];
                    line.tiles.Add(tile);
                }
            }
        }

        public void createEmptyModel()
        {
            this.model.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Line line = new Line(i);
                for (int j = 1; j <= i; j++)
                {
                    Tile tile = new Tile(j);
                    tile.color = Color.Transparent;

                    line.tiles.Add(tile);
                }
                this.model.Add(line);
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
            createEmptyModel();

            if (transformedEntity != String.Empty)
            {
                String[] lines = transformedEntity.Split('\r');

                foreach (string line in lines)
                {
                    String[] tileInfo = line.Split(',');

                    Line actualLine = model.Find(x => x.id == Convert.ToInt32(tileInfo[0]));
                    int quantity = Convert.ToInt32(tileInfo[2]);

                    for (; quantity > 0; quantity--)
                    {
                        Tile actualTile = actualLine.tiles.ElementAt(quantity - 1);
                        actualTile.id = Convert.ToInt32(tileInfo[1]);
                        actualTile.color = colors[actualTile.id];
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

                    string stringId = Regex.Match(tileInfo[2], @"\d+").Value;

                    Line actualLine = wall.Find(x => x.id == Convert.ToInt32(tileInfo[0]));
                    Tile actualTile = actualLine.tiles.Single(x => x.id == Convert.ToInt32(stringId));

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
                String[] entity = result.Split(new [] { "modelo", "parede", "chão" }, StringSplitOptions.None);
                entity = entity.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                this.createModel(entity[0]);
                this.createWall(entity[1]);
                this.createFloor(entity[2]);
            }
        }

        public void listPlayers()
        {
            string result = Jogo.ListarJogadores(this.id);

            this.players.Clear();
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

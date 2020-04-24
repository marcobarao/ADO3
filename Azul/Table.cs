using AzulServer;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Azul
{
    public partial class Table : Form
    {
        public System.Threading.Timer timer { get; set; }
        public Game game { get; set; }
        public Player player { get; set; }

        public Table()
        {
            InitializeComponent();
            this.tmrCheck.Start();
        }

        public Table(Game game, Player player)
        {
            InitializeComponent();
            this.game = game;
            this.player = player;
            this.tmrCheck.Start();
        }

        private void Table_Load(object sender, EventArgs e)
        {
            lstModel.DisplayMember = "id";
            lstModel.ValueMember = "id";
            lstModel.DataSource = this.game.model;

            lblScore.Text = this.player.score.ToString();
            drawWall();
            drawModel();
        }

        private void autoPlay()
        {
            Factory factoryWithTile = this.game.factories.ToList().Find(factory => factory.tiles.Count > 0);
            Tile tile;
            string type;
            Line modelWithTileColorOrEmpty;
            if (factoryWithTile != null)
            {
                type = "F";
                tile = factoryWithTile.tiles.FirstOrDefault();
                modelWithTileColorOrEmpty = this.game.model.ToList().Find(model =>
                {
                    Tile firstTile = model.tiles.First();
                    return firstTile.color == Color.Transparent || firstTile.color == tile.color;
                });    
            }
            else
            {
                factoryWithTile = new Factory(0);
                type = "C";
                tile = this.game.center.tiles.FirstOrDefault();
                modelWithTileColorOrEmpty = this.game.model.ToList().Find(model =>
                {
                    Tile firstTile = model.tiles.First();
                    return firstTile.color == Color.Transparent || firstTile.color == tile.color;
                });
            }

            bool success = this.player.play(type, factoryWithTile, tile, modelWithTileColorOrEmpty);
            if (success)
            {
                this.tmrCheck.Start();
                this.refreshTable();
            }
        }

        private void drawWall()
        {
            this.game.wall.ForEach(line =>
            {
                foreach (var tile in line.tiles)
                {
                    Panel panel = new Panel();
                    panel.BackColor = tile.color;
                    panel.Parent = flpWall;
                    panel.Name = $"pnlWall{line.id}{tile.id}";
                    panel.Size = new System.Drawing.Size(30, 30);

                    flpWall.Controls.Add(panel);
                }
            });
        }

        private void drawModel()
        {
            flpModel.Controls.Clear();
            this.game.model.ForEach(line =>
            {
                for (int i = 5; i > line.id; i--)
                {
                    Panel panel = new Panel();
                    panel.BackColor = Color.FromArgb(0, 0, 0, 0);
                    panel.Parent = flpModel;
                    panel.Name = $"pnlModel{line.id}{i}";
                    panel.Size = new System.Drawing.Size(30, 30);

                    flpModel.Controls.Add(panel);
                }

                foreach (var tile in line.tiles.Reverse())
                {
                    Panel panel = new Panel();
                    panel.BackColor = tile.color;
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    panel.Parent = flpModel;
                    panel.Name = $"pnlModel{line.id}{tile.id}";
                    panel.Size = new System.Drawing.Size(30, 30);

                    flpModel.Controls.Add(panel);
                }
            });
        }

        private void lstFactories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Factory selectedFactory = (Factory)lstFactories.SelectedItem;
            if (selectedFactory == null) return;

            lstTiles.DisplayMember = "color";
            lstTiles.ValueMember = "id";
            lstTiles.DataSource = selectedFactory.tiles;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.player.startGame(this.game);
        }

        private void lstTiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshFactories_Click(object sender, EventArgs e)
        {
            this.game.readFactories(this.player);

            lstFactories.DisplayMember = "id";
            lstFactories.ValueMember = "id";
            lstFactories.DataSource = this.game.factories;
        }

        private void btnRefreshCenter_Click(object sender, EventArgs e)
        {
            this.game.readCenter(this.player);

            lstCenter.DisplayMember = "color";
            lstCenter.ValueMember = "id";
            lstCenter.DataSource = this.game.center.tiles;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            autoPlay();
            this.game.readFactories(this.player);
            this.game.readCenter(this.player);
            this.refreshTable();
        }

        private void refreshTable()
        {
            this.game.readTable(this.player, this.player);

            int idxx = 0;
            flowLayoutPanel2.Controls.Clear();

            foreach (var floorTile in this.game.floor.tiles)
            {
                Panel panel = new Panel();
                panel.BackColor = floorTile.color;
                panel.ForeColor = Color.FromArgb(floorTile.color.ToArgb() ^ 0xffffff);
                panel.Parent = flowLayoutPanel2;
                panel.Name = $"pnlFloor{idxx}{floorTile.id}";
                panel.Size = new System.Drawing.Size(35, 40);

                Label label = new Label();
                label.Location = new System.Drawing.Point(20, 20);
                label.Parent = panel;
                label.Name = "label" + idxx;
                label.Text = floorTile.penalty.ToString();
                label.Size = new System.Drawing.Size(20, 20);
                panel.Controls.Add(label);

                flowLayoutPanel2.Controls.Add(panel);
            }

            drawModel();

            this.game.wall.ForEach(line =>
            {
                foreach (var tile in line.tiles)
                {
                    Panel panel = this.Controls
                        .Find($"pnlWall{line.id}{tile.id}", true)
                        .OfType<Panel>()
                        .SingleOrDefault();
                    if (panel != null) panel.BackColor = tile.color;
                }
            });

            this.game.listPlayers();
            this.lblScore.Text = this.game.players.Single(player => player.id == this.player.id).score.ToString();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            this.refreshTable();
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            string result = Jogo.VerificarVez(this.player.id, this.player.password);
            result = result.Trim();

            if (result != String.Empty && !result.StartsWith("ERRO"))
            {
                String[] data = result.Split(',');
                int id = Convert.ToInt32(data[1]);

                Player playerTurn = this.game.players.Single(player => player.id == id);
                this.lblPlayer.Text = $@"Vez do jogador: {playerTurn.username}";

                if (id == this.player.id)
                {
                    this.tmrCheck.Stop();

                    this.game.readFactories(this.player);
                    this.game.readCenter(this.player);
                    autoPlay();
                }
            }
        }
    }
}

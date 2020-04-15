using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azul
{
    public partial class Table : Form
    {
        public Game game { get; set; }
        public Player player { get; set; }

        public Table()
        {
            InitializeComponent();
        }

        public Table(Game game, Player player)
        {
            InitializeComponent();
            this.game = game;
            this.player = player;
        }

        private void Table_Load(object sender, EventArgs e)
        {
            lstModel.DisplayMember = "id";
            lstModel.ValueMember = "id";
            lstModel.DataSource = this.game.model;

            lblId.Text = this.player.id.ToString();
            lblPassword.Text = this.player.password;

            lblScore.Text = this.player.score.ToString();
            drawWall();
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
            string type;
            Tile selectedTile;
            if (rdoTypeC.Checked)
            {
                type = "C";
                selectedTile = (Tile)lstCenter.SelectedItem;
            } else
            {
                type = "F";
                selectedTile = (Tile)lstTiles.SelectedItem;
            }

            Factory selectedFactory = (Factory)lstFactories.SelectedItem;
            Line selectedModel = (Line)lstModel.SelectedItem;
            if (selectedFactory == null || selectedModel == null || selectedTile == null) return;

            this.player.play(type, selectedFactory, selectedTile, selectedModel);

            this.game.readTable(this.player, this.player);
            this.game.model.ForEach(x =>
            {
                int idx = 1;
                foreach (var tile in x.tiles)
                {
                    Panel panel = this.Controls
                        .Find($"pnlModel{x.id}{idx}", true)
                        .OfType<Panel>()
                        .Single();
                    panel.BackColor = tile.color;
                    idx++;
                }
            });

            int idxx = 0;
            flowLayoutPanel2.Controls.Clear();

            foreach (var floorTile in this.game.floor.tiles)
            {
                Panel painel = new Panel();
                painel.BackColor = floorTile.color;
                painel.ForeColor = Color.FromArgb(floorTile.color.ToArgb() ^ 0xffffff);
                painel.Parent = flowLayoutPanel2;
                painel.Name = $"pnlFloor{idxx}{floorTile.id}";
                painel.Size = new System.Drawing.Size(35, 40);

                Label label = new Label();
                label.Location = new System.Drawing.Point(20, 20);
                label.Parent = painel;
                label.Name = "label" + idxx;
                label.Text = floorTile.penalty.ToString();
                label.Size = new System.Drawing.Size(20, 20);
                painel.Controls.Add(label);

                flowLayoutPanel2.Controls.Add(painel);
            }

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

        private void lstModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

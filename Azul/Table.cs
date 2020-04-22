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

            TimerCallback tmCallback = Check_Turn;
            System.Threading.Timer timer = new System.Threading.Timer(tmCallback, new AutoResetEvent(false), TimeSpan.FromSeconds(4), TimeSpan.FromSeconds(4));

            lblId.Text = this.player.id.ToString();
            lblPassword.Text = this.player.password;

            lblScore.Text = this.player.score.ToString();
            drawWall();
            drawModel();
        }

        private void Check_Turn(object objectInfo)
        {
            string result = Jogo.VerificarVez(this.player.id, this.player.password);
            result = result.Trim();
            if (result != String.Empty && !result.StartsWith("ERRO"))
            {
                String[] data = result.Split(',');
                int id = Convert.ToInt32(data[1]);

                this.game.yourTurn = id == this.player.id;
                
                //TODO: Fazer jogada automatica
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
            string type;
            Tile selectedTile;
            if (rdoTypeC.Checked)
            {
                type = "C";
                selectedTile = (Tile) lstCenter.SelectedItem;
            }
            else
            {
                type = "F";
                selectedTile = (Tile) lstTiles.SelectedItem;
            }

            Factory selectedFactory = (Factory) lstFactories.SelectedItem;
            Line selectedModel = (Line) lstModel.SelectedItem;
            if (selectedFactory == null || selectedModel == null || selectedTile == null) return;

            this.player.play(type, selectedFactory, selectedTile, selectedModel);

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
    }
}

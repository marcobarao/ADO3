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
            Model selectedModel = (Model)lstModel.SelectedItem;
            if (selectedFactory == null || selectedModel == null || selectedTile == null) return;

            this.player.play(type, selectedFactory, selectedTile, selectedModel);

            txtTable.Text = this.game.readTable(this.player, this.player);
        }

        private void lstModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

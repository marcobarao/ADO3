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
            this.game.readFactories(this.player);
            this.game.readCenter(this.player);

            lstFactories.DisplayMember = "id";
            lstFactories.ValueMember = "id";
            lstFactories.DataSource = this.game.factories;

            lstCenter.DisplayMember = "color";
            lstCenter.ValueMember = "id";
            lstCenter.DataSource = this.game.center.tiles;

            new System.Threading.Timer((x) =>
            {
                this.game.readFactories(this.player);
                this.game.readCenter(this.player);
            }, null, TimeSpan.Zero, TimeSpan.FromSeconds(3));

        }

        private void lstFactories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Factory selectedFactory = (Factory)lstFactories.SelectedItem;
            if (selectedFactory == null) return;

            lstTiles.DisplayMember = "color";
            lstTiles.ValueMember = "id";
            lstTiles.DataSource = selectedFactory.tiles;
        }
    }
}

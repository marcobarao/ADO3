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
    public partial class Azul : Form
    {
        public Player player { get; set; }
        public Lobby lobby { get; set; }

        public Game game { get; set; }

        public Azul()
        {
            this.lobby = new Lobby();
            InitializeComponent();

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            this.lobby.listGames("A");

            lstGames.DataSource = lobby.games;
            lstGames.DisplayMember = "name";
            lstGames.ValueMember = "id";
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pctSenac_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            Game game = (Game)lstGames.SelectedItem;
            game.password = txtPasswordJoin.Text;
            String username = txtNomeJogador.Text;

            player = new Player(username);
            lobby.joinGame(game, player);
        }

        private void txtNomeJogador_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeJogador_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            
            this.game = new Game(txtMatchName.Text, txtPasswordCreate.Text);
            this.lobby.createGame(this.game);
            /*
            game.name = txtMatchName.Text;
            game.password = txtPasswordCreate.Text;
            this.lobby.createGame(game);
            */
        }
    }
}

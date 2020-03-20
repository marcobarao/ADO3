using System;
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

            lstGames.DisplayMember = "name";
            lstGames.ValueMember = "id";
            lstGames.DataSource = this.lobby.games;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            this.lobby.games.Clear();
            this.lobby.listGames("A");
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            Game game = (Game)lstGames.SelectedItem;
            game.password = txtPasswordJoin.Text;
            String username = txtNomeJogador.Text;

            player = new Player(username);
            lobby.joinGame(game, player);
            game.players.Add(player);
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            
            this.game = new Game(txtMatchName.Text, txtPasswordCreate.Text);
            this.lobby.createGame(this.game);
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game selectedGame = (Game)lstGames.SelectedItem;
            if (selectedGame == null) return;

            lstPlayers.DisplayMember = "username";
            lstPlayers.ValueMember = "id";
            lstPlayers.DataSource = selectedGame.players;
            selectedGame.listPlayers();
        }
    }
}

using System;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Azul
{
    public partial class Azul : Form
    {
        public Lobby lobby { get; set; }

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

            Player player = new Player(username);
            lobby.joinGame(game, player);
            game.players.Add(player);

            this.Hide();
            Table table = new Table(game, player);
            table.Closed += (s, args) => this.Close();
            table.Show();
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {

            Game game = new Game(txtMatchName.Text, txtPasswordCreate.Text);
            this.lobby.createGame(game);
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listPlayers();
        }

        private void Azul_Load(object sender, EventArgs e)
        {
            lobby.listGames("A");
            this.listPlayers();
            

        }

        private void listPlayers()
        {
            Game selectedGame = (Game)lstGames.SelectedItem;
            if (selectedGame == null) return;

            lstPlayers.DisplayMember = "username";
            lstPlayers.ValueMember = "id";
            lstPlayers.DataSource = selectedGame.players;
            selectedGame.listPlayers();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            

            
        }
    }
}

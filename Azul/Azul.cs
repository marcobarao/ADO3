using System;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Azul
{
    public partial class Azul : Form
    {
        public Player player { get; set; }
        public Lobby lobby { get; set; }
        public Game game { get; set; }
        private Timer timer;

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
            this.game = (Game)lstGames.SelectedItem;
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
            this.listPlayers();
        }

        private void Azul_Load(object sender, EventArgs e)
        {
            lobby.listGames("A");
            this.listPlayers();

            timer = new Timer();
            timer.Tick += new EventHandler(tick);
            timer.Interval = 5000;
            timer.Start();
        }

        private void lstGames_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void tick(object sender, EventArgs e)
        {
            lobby.listGames("A");
            this.listPlayers();
        }

        private void listPlayers()
        {
            Game selectedGame = (Game)lstGames.SelectedItem;
            if (selectedGame == null) return;

            //selectedGame.players.Clear();

            lstPlayers.DisplayMember = "username";
            lstPlayers.ValueMember = "id";
            lstPlayers.DataSource = selectedGame.players;
            //selectedGame.listPlayers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPassPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)lstPlayers.SelectedItem;
            if (selectedPlayer == null && selectedPlayer.password == null) return;

            selectedPlayer.startGame(this.game);

        }
    }
}

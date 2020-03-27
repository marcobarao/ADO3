﻿using System;
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
            this.game.password = txtPasswordJoin.Text;
            String username = txtNomeJogador.Text;

            this.player = new Player(username);
            lobby.joinGame(this.game, this.player);
            this.game.players.Add(player);
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

            selectedGame.players.Clear();

            lstPlayers.DisplayMember = "username";
            lstPlayers.ValueMember = "id";
            lstPlayers.DataSource = selectedGame.players;
            selectedGame.listPlayers();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (this.player == null) return;

            this.player.startGame(this.game);

            this.Hide();
            Table table = new Table(this.game, this.player);
            table.Closed += (s, args) => this.Close();
            table.Show();
        }
    }
}

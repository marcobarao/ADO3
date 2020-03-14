﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzulServer;

namespace Azul
{
    class Lobby
    {
        public string version { get; private set; }
        public List<Game> games { get; set; }

        public Lobby()
        {
            this.version = Jogo.Versao;
        }

        public void listGames(Status status = Status.ALL)
        {
            string result = Jogo.ListarPartidas(status.ToString());

            // TODO: Formatar o resultado (partidas) utilizando a classe Game e adicionar na lista
            // this.games.add(game);
        }

        public Player joinGame(Game game, Player player)
        {
            string result = Jogo.EntrarPartida(game.id, player.username, game.password);

            // TODO: Formatar resultado (Id e senha do jogador) e adicionar isso a instancia player:
            // player.id = id;
            // player.password = password;

            return player;
        }

        public Game createGame(Game game)
        {
            string result = Jogo.CriarPartida(game.name, game.password);

            // TODO Formatar resultado (id da partida) e adicionar isso a instancia game;
            // game.id = id;

            return game;
        }
    }
}

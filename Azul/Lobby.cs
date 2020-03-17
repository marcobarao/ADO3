﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzulServer;

namespace Azul
{
    public class Lobby
    {
        public string version { get; private set; }
        public String[] games;

        public Lobby()
        {
            this.version = Jogo.Versao;
        }

        public void listGames(Status status)
        {
            string result = Jogo.ListarPartidas(Convert.ToString(Convert.ToChar(status)));


            //result.Replace('\r', "");
            result.Replace("\n", String.Empty);
            String[] matches = result.Split('\r');
            this.games = matches;


            /*
            foreach (String match in matches)
            {
                String[] matchInfo = match.Split(',');
                String id = matchInfo[0];
                String name = matchInfo[1];
                String date = matchInfo[2];
                String estado = matchInfo[3];
                
            }
            */
            
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
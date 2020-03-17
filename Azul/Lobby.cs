using System;
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
        public List<Game> games = new List<Game>();

        public Lobby()
        {
            this.version = Jogo.Versao;
        }

        public void listGames(String status)
        {
            string result = Jogo.ListarPartidas(status);

            result.Replace("\n", String.Empty);
            String[] matches = result.Split('\r');


            matches = matches.Take(matches.Length - 1).ToArray();
            
            foreach (String match in matches)
            {
                Game game = new Game();
                String[] matchInfo = match.Split(',');

                game.id = Convert.ToInt32(matchInfo[0]);
                game.name = matchInfo[1];
                game.date = DateTime.ParseExact(matchInfo[2], "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
                game.status = matchInfo[3];
                this.games.Add(game);
            }
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

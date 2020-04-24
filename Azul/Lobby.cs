using System;
using System.ComponentModel;
using System.Globalization;
using AzulServer;

namespace Azul
{
    public class Lobby
    {
        public string version { get; private set; }
        public BindingList<Game> games = new BindingList<Game>();
        

        public Lobby()
        {
            this.version = Jogo.Versao;
        }

        public void listGames(String status)
        {
            string result = Jogo.ListarPartidas(status);
            if (result != String.Empty)
            {
                result = result.Trim();
                result.Replace("\n", String.Empty);
                String[] matches = result.Split('\r');

                foreach (String match in matches)
                {
                    Game game = new Game();
                    String[] matchInfo = match.Split(',');

                    game.id = Convert.ToInt32(matchInfo[0]);
                    game.name = matchInfo[1];
                    game.date = DateTime.ParseExact(matchInfo[2], "dd/MM/yyyy",
                        CultureInfo.CreateSpecificCulture("pt-BR"));
                    game.status = matchInfo[3];
                    this.games.Add(game);
                }
            }
        }

        public void joinGame(Game game, Player player)
        {
            string result = Jogo.EntrarPartida(game.id, player.username, game.password);

            String[] playerInfo = result.Split(',');
            player.id = Convert.ToInt32(playerInfo[0]);
            player.password = playerInfo[1].Trim();
            game.createEmptyModel();
            game.createLightWall();
        }

        public void createGame(Game game)
        {
            string result = Jogo.CriarPartida(game.name, game.password);

            String[] matchInfo = result.Split(',');
            game.id = Convert.ToInt32(matchInfo[0]);
            this.games.Add(game);
        }
    }
}

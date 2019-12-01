

namespace rps_game.Models
{
    public class Torneio
    {

        public string Rps_tournament_winner(string player1, string player2)
        {
            Rps jogo = new Rps();
            return jogo.rps_game_winner(player1, setJogada(player1), player2, setJogada(player2));
        }

        public string setJogada(string jogador)
        {
            string jogada = "";           
            switch (jogador)
            {
                case "all":
                    jogada = "S";
                    break;
                case "arm":
                    jogada = "P";
                    break;
                case "dav":
                    jogada = "S";
                    break;
                case "div":
                    jogada = "R";
                    break;
                case "mic":
                    jogada = "S";
                    break;
                case "omr":
                    jogada = "P";
                    break;
                case "ric":
                    jogada = "R";
                    break;
                case "rix":
                    jogada = "P";
                    break;
            }
            return jogada;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rps_game.Models{
    public class Rps{
        
        Random rnd = new Random();

        public string rps_game_winner(string jogador1, string jogada1, string jogador2, string jogada2){
            string vencedor = "";
            jogada1 = jogada1.ToUpper();
            jogada2 = jogada2.ToUpper();
            if (jogador1.Equals("") || jogador2.Equals("")){
                vencedor = "WrongNumberOfPlayersError";
            }else{
                if (jogador2.Equals("CPU")) jogada2 = player2();
                switch (jogada1){
                    case "P":
                        if (jogada2 == "P") vencedor = jogador1;
                        if (jogada2 == "R") vencedor = jogador1;
                        if (jogada2 == "S") vencedor = jogador2;
                        break;
                    case "R":
                        if (jogada2 == "R") vencedor = jogador1;
                        if (jogada2 == "S") vencedor = jogador1;
                        if (jogada2 == "P") vencedor = jogador2;
                        break;
                    case "S":
                        if (jogada2 == "S") vencedor = jogador1;
                        if (jogada2 == "P") vencedor = jogador1;
                        if (jogada2 == "R") vencedor = jogador2;
                        break;
                    default:
                        vencedor = "NoSuchStrategyError";
                        break;
                }

            }
            return vencedor;
        }

    private string player2(){
            string jogada ="P";
            int num = rnd.Next(1, 4);
            switch (num){ 
                case 1: jogada = "P";
                    break;
                case 2:
                    jogada = "R";
                    break;
                case 4:
                    jogada = "S";
                    break;
            }
            return jogada;
        }
    }
}

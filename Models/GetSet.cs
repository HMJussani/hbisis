namespace rps_game.Models
{
    public class GetSet
    {
        public string player1 { get; set; }
        public string player2 { get; set; }
        public string player3 { get; set; }
        public string player4 { get; set; }
        public string player5 { get; set; }
        public string player6 { get; set; }
        public string player7 { get; set; }
        public string player8 { get; set; }
        public string jogada { get; set; }
        public string jogada1 { get; set; }
        public string jogada2 { get; set; }

        public string tradutor(string jogador)
        {
            string traducao = "";
            switch (jogador)
            {
                case "all":
                    traducao = "Allen";
                    break;
                case "arm":
                    traducao = "Armando";
                    break;
                case "dav":
                    traducao = "Dave";
                    break;
                case "div":
                    traducao = "David E";
                    break;
                case "mic":
                    traducao = "Michael";
                    break;
                case "omr":
                    traducao = "Omer";
                    break;
                case "ric":
                    traducao = "Richard";
                    break;
                case "rix":
                    traducao = "Richard X";
                    break;
            }
            return traducao;
        }

    }
}
using rps_game.Models;
using System.Web.Mvc;

namespace rps_game.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.play1 = "play1";
            ViewBag.play2 = "CPU";
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            Rps jogo = new Rps();
            GetSet getSet = new GetSet()
            {
                player1 = form["player1"],
                player2 = form["player2"],
                jogada1 = form["joga1"],
                jogada2 = form["joga2"]
            };

            ViewBag.play1 = getSet.player1;
            ViewBag.play2 = getSet.player2;

            ViewBag.jogada1 = getSet.jogada1;
            ViewBag.jogada2 = getSet.jogada2;
            string result = jogo.rps_game_winner(getSet.player1, getSet.jogada1, getSet.player2, getSet.jogada2);
            if (result == getSet.player1) ViewBag.jogada = getSet.jogada1;
            else if (result == getSet.player2) ViewBag.jogada = getSet.jogada2;
            ViewBag.vencedor = result;
            return View();
        }


        public ActionResult Jogo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Jogo(FormCollection form)
        {
            GetSet getSet = new GetSet()
            {
                player1 = form["player1"],
                player2 = form["player2"],
                player3 = form["player3"],
                player4 = form["player4"],
                player5 = form["player5"],
                player6 = form["player6"],
                player7 = form["player7"],
                player8 = form["player8"]
            };
            Torneio torneio = new Torneio { };

            string quartas1 = torneio.Rps_tournament_winner(getSet.player1, getSet.player2);
            string quartas2 = torneio.Rps_tournament_winner(getSet.player3, getSet.player4);
            string quartas3 = torneio.Rps_tournament_winner(getSet.player5, getSet.player6);
            string quartas4 = torneio.Rps_tournament_winner(getSet.player7, getSet.player8);
            string final1 = torneio.Rps_tournament_winner(quartas1, quartas2);
            string final2 = torneio.Rps_tournament_winner(quartas3, quartas4);
            string vencedor = torneio.Rps_tournament_winner(final1, final2);
            ViewBag.quartas1 = getSet.tradutor(quartas1);
            ViewBag.quartas2 = getSet.tradutor(quartas2);
            ViewBag.quartas3 = getSet.tradutor(quartas3);
            ViewBag.quartas4 = getSet.tradutor(quartas4);
            ViewBag.final1 = getSet.tradutor(final1);
            ViewBag.final2 = getSet.tradutor(final2);
            ViewBag.vencedor = getSet.tradutor(vencedor);
            ViewBag.jogada = torneio.setJogada(vencedor);
            return View();
        }

        public ActionResult About()
        {

            return View();
        }
    }
}
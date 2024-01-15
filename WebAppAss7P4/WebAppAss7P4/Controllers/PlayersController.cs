using Microsoft.AspNetCore.Mvc;
using WebAppAss7P4.Models;

namespace WebAppAss7P4.Controllers
{
    public class PlayersController : Controller
    {
        static List<Players> players = new List<Players>()
        {
            new Players() {PId = 1, PName="Raina",PCountry="India",PType="All-rounder"},
            new Players() {PId = 2, PName="Warner",PCountry="Australia",PType="Batsman"},
            new Players() {PId = 3, PName="Kohli",PCountry="India",PType="Batsman"},
            new Players() {PId = 4, PName="Southee",PCountry="NZ",PType="Bowler"},
        };
        public IActionResult Display()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Players());
        }

        [HttpPost]
        public IActionResult Create(Players pro)
        {
            if (ModelState.IsValid)
            {
                players.Add(pro);
                return RedirectToAction("Display");
            }
            return View();
        }
    }
}

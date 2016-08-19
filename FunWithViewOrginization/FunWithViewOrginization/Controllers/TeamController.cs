using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FunWithViewOrginization.Models;

namespace FunWithViewOrginization.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            var players = new List<Player>()
            {
                new Player() {Name = "Franny Linor", Number = 12, Position = "SS"},
                new Player() {Name = "Jason Kitness", Number = 22, Position = "2nd Base"}
            };


            return View(players);
        }
    }
}
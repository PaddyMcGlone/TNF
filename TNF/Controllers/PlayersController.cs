using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TNF.Models;

namespace TNF.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            var players = new List<Players>
            {
                new Players { FullName = "Eddie Hollywood" }
            };

            return View();
        }
    }
}
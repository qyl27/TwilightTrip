using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TwilightTrip.DbModels;
using TwilightTrip.Models;

namespace TwilightTrip.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> Log { get; }
        private TwilightTripContext Db { get; }

        public HomeController(ILogger<HomeController> logger, TwilightTripContext context)
        {
            Log = logger;
            Db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

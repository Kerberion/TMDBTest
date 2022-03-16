using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TMBDTest.Interfaces;
using TMBDTest.Models;

namespace TMBDTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IPeliculaRepository _peliculaRepository;

        public HomeController(ILogger<HomeController> logger,IPeliculaRepository peliculaRepository)
        {
            _logger = logger;
            _peliculaRepository = peliculaRepository;
        }

        public IActionResult Index()
        {

            var generiResponse = _peliculaRepository.GetPopular();
            PopularViewModel popularViewModel = generiResponse.datos;
            return View(popularViewModel);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

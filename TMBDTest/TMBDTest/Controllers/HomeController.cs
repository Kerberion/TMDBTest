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
        private readonly ITvShowRepository _tvShowRepository;

        public HomeController(ILogger<HomeController> logger,IPeliculaRepository peliculaRepository, ITvShowRepository tvShowRepository)
        {
            _logger = logger;
            _peliculaRepository = peliculaRepository;
            _tvShowRepository = tvShowRepository;
        }

        public IActionResult Index()
        {
            var mainViewmodel = new MainViewModel();

            //Películas

            var generiResponsePopular = _peliculaRepository.GetPopular();
            PopularViewModel popularViewModel = generiResponsePopular.datos;

            var generiResponseRecommendations = _peliculaRepository.GetRecommendations();
            RecommendationsViewModel recommendationsViewModel = generiResponseRecommendations.datos;

            var generiResponseRated = _peliculaRepository.GetRated();
            RatedViewModel ratedViewModel = generiResponseRated.datos;

            //TV Shows

            var generiResponseTvPopular = _tvShowRepository.GetTvPopular();
            TvPopularViewModel tvPopularViewModel = generiResponseTvPopular.datos;

            var generiResponseTvRecommendations = _tvShowRepository.GetTvRecommendations();
            TvRecommendationsViewModel tvRecommendationsViewModel = generiResponseTvRecommendations.datos;

            var generiResponseTvRated = _tvShowRepository.GetTvRated();
            TvRatedViewModel tvRatedViewModel = generiResponseTvRated.datos;

            mainViewmodel.popularViewModel = popularViewModel;
            mainViewmodel.recommendationsViewModel = recommendationsViewModel;
            mainViewmodel.ratedViewModel = ratedViewModel;
            mainViewmodel.tvPopularViewModel = tvPopularViewModel;
            mainViewmodel.tvRecommendationsViewModel = tvRecommendationsViewModel;
            mainViewmodel.tvRatedViewModel = tvRatedViewModel;

            return View(mainViewmodel);
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

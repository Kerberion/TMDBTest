using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMBDTest.Interfaces;
using TMBDTest.Models;
using TMBDTest.Services;

namespace TMBDTest.Repository
{
    public class TvShowRepository : ITvShowRepository
    {
        private ServiceClient _serviceClient { get; set; }
        private string _apiKey { get; set; }
        public TvShowRepository()
        {
            _apiKey = Global.Settings.ApiKey;
        }
        public GenericResponse<TvPopularViewModel> GetTvPopular()
        {
            var response = new GenericResponse<TvPopularViewModel>();
            _serviceClient = new ServiceClient();

            Task.Run(async () => response = await _serviceClient.Get<TvPopularViewModel>($"tv/popular?api_key={_apiKey}&language=es&page=1", false)).Wait();

            return response;
        }

        public GenericResponse<TvRecommendationsViewModel> GetTvRecommendations()
        {
            var response = new GenericResponse<TvRecommendationsViewModel>();
            _serviceClient = new ServiceClient();

            Task.Run(async () => response = await _serviceClient.Get<TvRecommendationsViewModel>($"tv/60574/recommendations?api_key={_apiKey}&language=es&page=1", false)).Wait();

            return response;
        }


    }
}

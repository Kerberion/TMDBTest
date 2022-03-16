using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMBDTest.Interfaces;
using TMBDTest.Models;
using TMBDTest.Services;

namespace TMBDTest.Repository
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private ServiceClient _serviceClient { get; set; }
        private string _apiKey { get; set; }

        public PeliculaRepository()
        {
            _apiKey = Global.Settings.ApiKey;
        }

        public GenericResponse<PopularViewModel> GetPopular()
        {
            var response = new GenericResponse<PopularViewModel>();
            _serviceClient = new ServiceClient();            

            Task.Run(async () => response = await _serviceClient.Get<PopularViewModel>($"movie/popular?api_key={_apiKey}&language=es&page=1", false)).Wait();

            return response;
        }

        public GenericResponse<RecommendationsViewModel> GetRecommendations()
        {
            var response = new GenericResponse<RecommendationsViewModel>();
            _serviceClient = new ServiceClient();

            Task.Run(async () => response = await _serviceClient.Get<RecommendationsViewModel>($"movie/634649/recommendations?api_key={_apiKey}&language=es&page=1", false)).Wait();

            return response;
        }

        public GenericResponse<RatedViewModel> GetRated()
        {
            var response = new GenericResponse<RatedViewModel>();
            _serviceClient = new ServiceClient();

            Task.Run(async () => response = await _serviceClient.Get<RatedViewModel>($"movie/top_rated?api_key={_apiKey}&language=es&page=1", false)).Wait();

            return response;
        }
    }
}

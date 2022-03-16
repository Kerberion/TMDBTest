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

            //response = _serviceClient.Get<PopularViewModel>("", false);

            Task.Run(async () => response = await _serviceClient.Get<PopularViewModel>($"movie/634649/recommendations?api_key={_apiKey}&language=en-US&page=1", false)).Wait();

            return response;
        }

        public GenericResponse<RecommendationsViewModel> GetRecommendations()
        {
            throw new NotImplementedException();
        }
    }
}

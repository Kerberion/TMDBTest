using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMBDTest.Models;

namespace TMBDTest.Interfaces
{
    public interface ITvShowRepository
    {
        GenericResponse<TvPopularViewModel> GetTvPopular();
        GenericResponse<TvRecommendationsViewModel> GetTvRecommendations();
        GenericResponse<TvRatedViewModel> GetTvRated();
    }
}

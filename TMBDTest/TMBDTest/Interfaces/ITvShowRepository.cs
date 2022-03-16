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
        //GenericResponse<RecommendationsViewModel> GetTvRecommendations();
        //GenericResponse<RatedViewModel> GetTvRated();
    }
}

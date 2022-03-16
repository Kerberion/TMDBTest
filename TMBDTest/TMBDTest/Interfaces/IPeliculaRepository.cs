using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMBDTest.Models;

namespace TMBDTest.Interfaces
{
    public interface IPeliculaRepository
    {
        GenericResponse<RecommendationsViewModel> GetRecommendations();
        GenericResponse<PopularViewModel> GetPopular();
    }
}

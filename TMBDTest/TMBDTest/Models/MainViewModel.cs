using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMBDTest.Models
{
    public class MainViewModel
    {
        public PopularViewModel popularViewModel {get;set;}
        public RecommendationsViewModel recommendationsViewModel { get; set; }
        public RatedViewModel ratedViewModel { get; set; }
        public TvPopularViewModel tvPopularViewModel { get; set; }

        public MainViewModel()
        {
            popularViewModel = new PopularViewModel();
            recommendationsViewModel = new RecommendationsViewModel();
            ratedViewModel = new RatedViewModel();
            tvPopularViewModel = new TvPopularViewModel();
        }
    }
}

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

        public MainViewModel()
        {
            popularViewModel = new PopularViewModel();
            recommendationsViewModel = new RecommendationsViewModel();
        }
    }
}

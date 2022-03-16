using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMBDTest.Models
{
    public class TvPopularViewModel
    {
        public int page { get; set; }
        public List<TvResultsViewModel> results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public TvPopularViewModel()
        {
            page = 0;
            results = new List<TvResultsViewModel>();
            total_results = 0;
            total_pages = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMBDTest.Models
{
    public class RecommendationsViewModel
    {
        public int page { get; set; }
        public resultsViewModel results { get; set; }       
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public RecommendationsViewModel()
        {
            page = 0;
            total_results = 0;
            total_pages = 0;
        }
    }

   
}

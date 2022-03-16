using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMBDTest.Models
{
    //[JsonArray]
    public class resultsViewModel
    {
        public string? poster_path { get; set; }
        public Boolean adult { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
        public List<int> genre_ids { get; set; }
        public int id { get; set; }
        public string original_title { get; set; }
        public string original_language { get; set; }
        public string title { get; set; }
        public string backdrop_path { get; set; }
        public double popularity { get; set; }
        public int vote_count { get; set; }
        public Boolean video { get; set; }
        public double vote_average { get; set; }

        public resultsViewModel()
        {
            poster_path = string.Empty;
            adult = false;
            overview = string.Empty;
            release_date = string.Empty;
            genre_ids = new List<int>();
            id = 0;
            original_title = string.Empty;
            original_language = string.Empty;
            title = string.Empty;
            backdrop_path = string.Empty;
            popularity = 0.00;
            vote_count = 0;
            video = false;
            vote_average = 0.00;
        }
       
    }
}

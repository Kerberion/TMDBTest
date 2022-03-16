using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMBDTest.Models
{
    public class TvResultsViewModel
    {
        public Boolean adult { get; set; }
        public string backdrop_path { get; set; }
        public List<int> genre_ids { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public List<string> origin_country { get; set; }
        public string original_language { get; set; }
        public string original_name { get; set; }               
        public string overview { get; set; }
        public double popularity { get; set; }
        public string? poster_path { get; set; }
        public string first_air_date { get; set; }
        public double vote_average { get; set; }                                        
        public int vote_count { get; set; }
        
                                            
       
        public TvResultsViewModel()
        {
            adult = false;
            backdrop_path = string.Empty;
            genre_ids = new List<int>();
            id = 0;
            name = string.Empty;
            origin_country = new List<string>();
            original_language = string.Empty;
            original_name = string.Empty;
            overview = string.Empty;
            popularity = 0.00;
            poster_path = string.Empty;
            first_air_date = string.Empty;
            vote_average = 0.00;
            vote_count = 0;
        }
    }
}

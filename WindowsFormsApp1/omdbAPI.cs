using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class omdbAPI
    {
        public class Ratings
        {
            public string Source { get; set; }
            public string Value { get; set; }
        }
        public class root
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string Rated { get; set; }
            public string Released { get; set; }
            public string Runtime { get; set; }
            public string Genre { get; set; }
            public string Director { get; set; }
            public string Writer { get; set; }
            public string Actors { get; set; }
            public string Plot { get; set; }
            public string Language { get; set; }
            public string Country { get; set; }
            public string Awards { get; set; }
            public string Poster { get; set; }
            public List<Ratings> Ratings { get; set; }
            public string imdbRating { get; set; }
            public string imdbVotes { get; set; }
            public string Type { get; set; }
        }
    }
}

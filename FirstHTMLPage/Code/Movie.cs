using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstHTMLPage.Code
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Cast { get; set; }

        public Movie()
        { }
        public Movie(string title, string director, int releaseYear, string cast)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
            Cast = cast;
        }
    }
}
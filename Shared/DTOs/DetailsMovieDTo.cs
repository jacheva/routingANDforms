using Routing.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Share.DTOs
{
    public class DetailsMovieDTo
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Person> Actors { get; set; }
    }
}

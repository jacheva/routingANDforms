using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Entities
{
    public class MoviesActors
    {
        public int PersonId { get; set; }
        public int MovieID { get; set; }
        public Person Person { get; set; }
        public Movie Movie { get; set; }
        public string Character { get; set; }
        public int Odrer { get; set; }
    }
}

using Routing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Share.DTOs
{
    public class IndexPageDTO
    {
        public List<Movie> Intheaters { get; set; }
        public List<Movie> UpcomingReleases { get; set; }
    }
}

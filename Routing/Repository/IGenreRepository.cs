using Routing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(Genre genre);
    }
}

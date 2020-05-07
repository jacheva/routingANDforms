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
        Task<List<Genre>> GetGenres();
        Task<Genre> GetGenres(int id);
        Task UpdateGenre(Genre genre);
        Task DeleteGenre(int Id);
    }
}

using Microsoft.AspNetCore.Mvc;
using Routing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return _db.Movies.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            return _db.Movies.FirstOrDefault(x => x.Id == id);
        }

        [HttpGet("{id}/{id2}")]
        public ActionResult<Movie> Get(int id, int id2)
        {
            return _db.Movies.FirstOrDefault(x => x.Id == id);
        }

        [HttpGet("GetByName/{name}")]
        public ActionResult<Movie> GetByName(string name)
        {
            return _db.Movies.FirstOrDefault(x => x.Title == name);
        }
    }
}

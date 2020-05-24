using Routing.Helpers;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Repository
{
    public class RatingRepository: IRatingRepository
    {
        private readonly IHttpService httpService;
        private readonly string urlBase = "https://localhost:44389/api/rating";

        public RatingRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task Vote(MovieRating movieRating)
        {
            var httpResponse = await httpService.Post(urlBase, movieRating);
            
            if (!httpResponse.Success)
            {
                throw new ApplicationException(await httpResponse.GetBody());
            }
        }
    }

}

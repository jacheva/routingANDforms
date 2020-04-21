using Routing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Repository
{
    public interface IPersonRepository
    {
        Task CreatePerson(Person person);
    }
}

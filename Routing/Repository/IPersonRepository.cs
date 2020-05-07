using Routing.Entities;
using Share.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Repository
{
    public interface IPersonRepository
    {
        Task CreatePerson(Person person);
        Task DeletePerson(int Id);
        Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDTO paginationDTO);
      
        Task<List<Person>> GetPeopleByName(string name);
        Task<Person> GetPersonById(int Id);
        Task UpdatePerson(Person person);
    }
}

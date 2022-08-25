using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GEtByIDAsync(int id);
        Task AddAsync(Actor actor);
        Task UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);
    }
}

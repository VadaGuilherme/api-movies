using MyMovies.Domain.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMovies.Domain.Core.Contracts
{
    public interface IMoviesRepository
    {
        Task<IEnumerable<Movies>> GetAllMovies();
    }
}

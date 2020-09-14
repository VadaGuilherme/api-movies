using Microsoft.EntityFrameworkCore;
using MyMovies.Domain.Core.Contracts;
using MyMovies.Domain.Core.Entities;
using MyMovies.Infrastructure.SqlServer.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyMovies.Infrastructure.SqlServer.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly MyMoviesContext _context;

        public MoviesRepository(MyMoviesContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movies>> GetAllMovies()
        {
            return await _context.Movies
                .AsNoTracking()
                .ToListAsync();
        }
    }
}

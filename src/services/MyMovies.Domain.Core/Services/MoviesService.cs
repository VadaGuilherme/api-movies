using MyMovies.Domain.Core.Contracts;
using MyMovies.Domain.Core.Models.Response.ResponseMessage;
using System;
using System.Threading.Tasks;

namespace MyMovies.Domain.Core.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _moviesRepository;

        public MoviesService(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        public async Task<ResponseMessage> GetAllMovies()
        {
            try
            {
                var movies = await _moviesRepository.GetAllMovies();

                if (movies is null)
                    return ResponseMessage.ErrorValidation(null, "Filmes não encontrados");

                return ResponseMessage.Ok(movies);
            }
            catch (Exception ex)
            {
                return ResponseMessage.ErrorValidation(null, ex.Message);
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MyMovies.Domain.Core.Contracts;
using MyMovies.Domain.Core.Models.Response.ResponseMessage;
using System.Threading.Tasks;

namespace MyMovies.Api.Controllers
{
    [Route("api/v1/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        /// <summary>
        ///     Find All Movies
        /// </summary>
        /// <returns>List of Movies</returns>
        [HttpGet]
        public async Task<ResponseMessage> GetAllMovies() =>
            await _moviesService.GetAllMovies();
    }
}

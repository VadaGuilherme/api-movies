using MyMovies.Domain.Core.Models.Response.ResponseMessage;
using System.Threading.Tasks;

namespace MyMovies.Domain.Core.Contracts
{
    public interface IMoviesService
    {
        Task<ResponseMessage> GetAllMovies();
    }
}

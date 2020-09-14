using Microsoft.Extensions.DependencyInjection;
using MyMovies.Domain.Core.Contracts;
using MyMovies.Domain.Core.Services;
using MyMovies.Infrastructure.SqlServer.Contexts;
using MyMovies.Infrastructure.SqlServer.Repositories;

namespace MyMovies.Api.Extensions
{
    public static class DependencyInjectionConfiguration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<MyMoviesContext>();

            #region Services
            services.AddScoped<IMoviesService, MoviesService>();
            #endregion

            #region Repository
            services.AddScoped<IMoviesRepository, MoviesRepository>();
            #endregion
        }
    }
}

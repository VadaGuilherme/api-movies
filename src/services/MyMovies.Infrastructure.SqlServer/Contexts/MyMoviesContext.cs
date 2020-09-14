using Microsoft.EntityFrameworkCore;
using MyMovies.Domain.Core.Entities;
using System.Linq;

namespace MyMovies.Infrastructure.SqlServer.Contexts
{
    public class MyMoviesContext: DbContext
    {
        public MyMoviesContext(DbContextOptions<MyMoviesContext> options) : base(options) { }

        public DbSet<Movies> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyMoviesContext).Assembly);
        }
    }
}

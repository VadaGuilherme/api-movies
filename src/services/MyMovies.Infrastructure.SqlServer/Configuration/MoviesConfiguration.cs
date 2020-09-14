using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMovies.Domain.Core.Entities;

namespace MyMovies.Infrastructure.SqlServer.Configuration
{
    public class MoviesConfiguration : IEntityTypeConfiguration<Movies>
    {
        public void Configure(EntityTypeBuilder<Movies> builder)
        {
            builder.ToTable("Movies");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasColumnType("varchar(55)");

            builder.Property(c => c.Text)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(c => c.Img)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(c => c.Release)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}

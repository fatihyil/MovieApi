using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Persistence.Context
{
    public class MovieContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JARVIS\\sqlexpress;initial Catalog=ApiMovieDb;integrated Security=true;TrustServerCertificate=True");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}

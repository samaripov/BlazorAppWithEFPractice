using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorWebAppMovies.Model;

namespace BlazorWebAppMovies.Data
{
    public class BlazorWebAppMoviesContext : DbContext
    {
        public BlazorWebAppMoviesContext (DbContextOptions<BlazorWebAppMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorWebAppMovies.Model.Movie> Movie { get; set; } = default!;
    }
}

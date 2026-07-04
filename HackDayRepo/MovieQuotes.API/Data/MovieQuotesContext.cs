using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieQuotes.API;

    public class MovieQuotesContext : DbContext
    {
        public MovieQuotesContext (DbContextOptions<MovieQuotesContext> options)
            : base(options)
        {
        }

        public DbSet<MovieQuotes.API.MovieQuotes>? MovieQuotes { get; set; }
    }

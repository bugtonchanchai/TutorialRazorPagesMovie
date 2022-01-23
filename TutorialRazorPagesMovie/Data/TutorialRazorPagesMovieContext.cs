#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace TutorialRazorPagesMovie.Data
{
    public class TutorialRazorPagesMovieContext : DbContext
    {
        public TutorialRazorPagesMovieContext (DbContextOptions<TutorialRazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}

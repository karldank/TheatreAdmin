using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MVCMusicApp.Data
{
    public class MVCMusicAppContext : DbContext
    {
        public MVCMusicAppContext (DbContextOptions<MVCMusicAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}

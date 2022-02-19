#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netwebapp.Models;

namespace netwebapp.Data
{
    public class netwebappContext : DbContext
    {
        public netwebappContext (DbContextOptions<netwebappContext> options)
            : base(options)
        {
        }

        public DbSet<netwebapp.Models.Movie> Movie { get; set; }
    }
}

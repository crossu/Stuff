using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Practice.Models
{
    public class MVC_PracticeContext : DbContext
    {
        public MVC_PracticeContext (DbContextOptions<MVC_PracticeContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Practice.Models.Movie> Movie { get; set; }
    }
}

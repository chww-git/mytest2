#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myTest1.Models;

namespace myTest1.Data
{
    public class myTest1Context : DbContext
    {
        public myTest1Context (DbContextOptions<myTest1Context> options)
            : base(options)
        {
        }

        public DbSet<myTest1.Models.Movie> Movie { get; set; }
    }
}

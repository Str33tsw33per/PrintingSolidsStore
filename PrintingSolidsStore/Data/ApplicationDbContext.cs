using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrintingSolidsStore.Models;
using Microsoft.EntityFrameworkCore;

namespace PrintingSolidsStore.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products{ get; set; }
    }
}

using DotNetCoreDemoProject.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DotNetCoreDemoProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }


}




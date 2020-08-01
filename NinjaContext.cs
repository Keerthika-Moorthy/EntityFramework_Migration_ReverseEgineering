using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NinjaApp.Domain; 

namespace NinjaApp.Data
{
    public class NinjasContext : DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = NewNinjaAppData");
           
        }
    }


}

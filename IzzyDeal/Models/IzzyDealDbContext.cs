using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Entity;
using Microsoft.Extensions.PlatformAbstractions;

namespace IzzyDeal.Models
{
    public class IzzyDealDbContext : DbContext
    {
        public IzzyDealDbContext()
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<StoreLocation> StoreLocations { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = PlatformServices.Default.Application.ApplicationBasePath;
            optionsBuilder.UseSqlite("Filename=" + Path.Combine(path, "IzzyDeal.db"));
        }
    }
    
}
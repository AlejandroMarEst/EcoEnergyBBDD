﻿using EcoEnergyBBDD.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoEnergyBBDD.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<EnergySystem> Simulacions { get; set; }
        public DbSet<WaterConsumptionLog> WaterConsumption { get; set; }
        public DbSet<EnergyIndicator> EnergyIndicator { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connection = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connection);
        }
    }
}

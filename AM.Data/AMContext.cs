using AM.Core.Domain; 
using Microsoft.EntityFrameworkCore;
using System;
using System.Numerics;
using AM.Data.Configurations;
namespace AM.Data
{
    public class AMContext : DbContext
    {
      

        // Option 2 : override OnConfiguring si tu veux coder la chaîne ici (utile pour tests)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                  @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Airport;Integrated Security=True");
            }
        }

        // DbSets : une propriété DbSet par entité
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Core.Domain.Plane> Planes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        // si tu as des classes dérivées (Staff, Traveller) tu peux ajouter DbSet<Staff> etc.
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfig());
            modelBuilder.ApplyConfiguration(new FlightConfig());

            base.OnModelCreating(modelBuilder);
        }
        // Nouvelle méthode pour les conventions personnalisées
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // Appliquer la convention à toutes les propriétés DateTime
            configurationBuilder.Properties<DateTime>()
                .HaveColumnType("date"); // Utiliser type 'date' au lieu de 'datetime2'
        }

    }
}

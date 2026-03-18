using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;
namespace AM.Data.Configurations
{
    public class FlightConfig : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f => f.Flightid);

            builder.HasOne(f => f.Plane)       // relation one-to-many
                   .WithMany()                 // ou .WithMany(p => p.Flights) si Plane a navigation
                   .HasForeignKey(f => f.PlaneId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(f => f.Passenger)  // many-to-many
                   .WithMany(p => p.Flights);

        }
    }
}

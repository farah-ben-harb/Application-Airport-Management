using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AM.Data.Configurations
{
    public class PlaneConfig : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.ToTable("MyPlanes"); // Nom de la table
            builder.HasKey(p => p.Planeid); // Clé primaire

            builder.Property(p => p.Capacity)
                   .HasColumnName("PlaneCapacity") // Nom de la colonne
                   .IsRequired();
        }
    }
}

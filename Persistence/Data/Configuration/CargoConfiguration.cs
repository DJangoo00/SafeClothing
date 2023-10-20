using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("cargo");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.Property(p => p.SueldoBase)
            .IsRequired()
            .HasColumnType("int");
        }
    }
}
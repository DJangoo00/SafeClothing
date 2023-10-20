using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("detalleVenta");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.ValorUnit)
            .IsRequired()
            .HasColumnType("int");
        }
    }
}
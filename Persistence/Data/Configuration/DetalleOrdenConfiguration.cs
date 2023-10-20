using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("detalleOrden");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.CantidadProducir)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.CantidadProducida)
            .IsRequired()
            .HasColumnType("int");

            builder.HasOne(p => p.Orden)
            .WithMany(p => p.DetalleOrdenes)
            .HasForeignKey(p => p.IdOrdenFk);
        }
    }
}
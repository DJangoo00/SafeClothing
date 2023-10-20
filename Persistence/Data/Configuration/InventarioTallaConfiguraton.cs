using System.Globalization;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Persistencia.Data.Configuration
{
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("inventarioTalla");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasColumnType("int");

            builder.HasOne(p => p.Talla)
            .WithMany(p => p.InventariosTallas)
            .HasForeignKey(p => p.IdTallaFk);

            builder.HasOne(p => p.Inventario)
            .WithMany(p => p.InventariosTallas)
            .HasForeignKey(p => p.IdInventarioFk);
        }
    }
}
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("prenda");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.IdePrenda)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.Property(p => p.ValorUnitCop)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.ValorUnitUsd)
            .IsRequired()
            .HasColumnType("int");

            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdEstadoFk);

            builder.HasOne(p => p.TipoProteccion)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdTipoProteccionFK);

            builder.HasOne(p => p.TipoProteccion)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdGenero);
        }
    }
}
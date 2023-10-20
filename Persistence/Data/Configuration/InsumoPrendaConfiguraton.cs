using System.Globalization;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Persistencia.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("insumoPrenda");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Cantidad)
            .IsRequired()
            .HasColumnType("int");

            builder.HasOne(p => p.Prenda)
            .WithMany(p => p.InsumosPrendas)
            .HasForeignKey(p => p.IdPrendaFk);

            builder.HasOne(p => p.Insumo)
            .WithMany(p => p.InsumosPrendas)
            .HasForeignKey(p => p.IdInsumoFk);
            
        }
    }
}
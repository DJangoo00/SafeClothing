using System.Globalization;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Persistencia.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("insumo");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.Property(p => p.ValorUnit)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.StockMin)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.StockMax)
            .IsRequired()
            .HasColumnType("int");

            builder
            .HasMany(p => p.Proveedores)
            .WithMany(m => m.Insumos)
            .UsingEntity<InsumoProveedor>(
                j => j
                    .HasOne(pt => pt.Proveedor)
                    .WithMany(t => t.InsumosProveedores)
                    .HasForeignKey(pt => pt.IdProveedorFk),
                j => j
                    .HasOne(pt => pt.Insumo)
                    .WithMany(t => t.InsumosProveedores)
                    .HasForeignKey(pt => pt.IdInsumoFk),
                j =>
                    {
                        j.ToTable("medicamentoProveedor");
                        j.HasKey(t => new { t.IdProveedorFk, t.IdInsumoFk });
                    });

            /* builder
            .HasMany(p => p.Prendas)
            .WithMany(m => m.Insumos)
            .UsingEntity<InsumoPrenda>(
                j => j
                    .HasOne(pt => pt.Prenda)
                    .WithMany(t => t.InsumosPrendas)
                    .HasForeignKey(pt => pt.IdPrendaFk),
                j => j
                    .HasOne(pt => pt.Insumo)
                    .WithMany(t => t.InsumosPrendas)
                    .HasForeignKey(pt => pt.IdInsumoFk),
                j =>
                    {
                        j.ToTable("medicamentoProveedor");
                        j.HasKey(t => new { t.IdPrendaFk, t.IdInsumoFk });
                    }); */
            
        }
    }
}
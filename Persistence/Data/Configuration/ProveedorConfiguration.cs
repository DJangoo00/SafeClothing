using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("proveedor");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.Property(p => p.Nit)
            .IsRequired()
            .HasColumnType("int");

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.IdTipoPersonaFk);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Proveedores)
            .HasForeignKey(p => p.IdMunicipioFk);
        }
    }
}
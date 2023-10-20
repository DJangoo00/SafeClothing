using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("empresa");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Nit)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.RazonSocial)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.Property(p => p.RepresetanteLegal)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.Property(p => p.FechaCreacion)
            .IsRequired()
            .HasColumnType("date");

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Empresas)
            .HasForeignKey(p => p.IdMunicipioFk);
        }
    }
}
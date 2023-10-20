using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("municipio");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.HasOne(p => p.Departamento)
            .WithMany(p => p.Municipios)
            .HasForeignKey(p => p.IdDepartamento);
        }
    }
}
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("departamento");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.HasOne(p => p.Pais)
            .WithMany(p => p.Departamentos)
            .HasForeignKey(p => p.IdPaisFk);
        }
    }
}
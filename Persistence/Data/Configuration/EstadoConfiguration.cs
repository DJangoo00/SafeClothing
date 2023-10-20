using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("estado");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.HasOne(p => p.TipoEstado)
            .WithMany(p => p.Estados)
            .HasForeignKey(p => p.IdTipoEstadoFk);
        }
    }
}
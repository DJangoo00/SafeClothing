using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("color");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);
        }
    }
}
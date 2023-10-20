using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class FormaPagoConfiguration : IEntityTypeConfiguration<FormaPago>
    {
        public void Configure(EntityTypeBuilder<FormaPago> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("formaPago");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);
        }
    }
}
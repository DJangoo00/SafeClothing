using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("cliente");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.DniCliente)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(50);

            builder.Property(p => p.FechaRegistro)
            .IsRequired()
            .HasColumnType("date")
            .HasMaxLength(50);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.IdMunicipioFk);
        }
    }
}
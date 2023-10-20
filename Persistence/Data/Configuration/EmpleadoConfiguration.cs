using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("empleado");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.DniEmpelado)
            .IsRequired()
            .HasColumnType("int");

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasColumnType("Varchar")
            .HasMaxLength(50);

            builder.Property(p => p.FechaIngreso)
            .IsRequired()
            .HasColumnType("date");

            builder.HasOne(p => p.Cargo)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdCargoFk);

            builder.HasOne(p => p.Municipio)
            .WithMany(p => p.Empleados)
            .HasForeignKey(p => p.IdMunicipioFk);
        }
    }
}
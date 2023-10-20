//dependencias externas
using Microsoft.EntityFrameworkCore;
using System.Reflection;
//namespaces internos
using Domain.Entities;

namespace Persistence;
public class ApiContext : DbContext //Clase de abstraccion para facilitar interaccion
{
    public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    
    //DbSet para la funcionalidad
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Medicamento> Medicamentos { get; set; }
    public DbSet<MedicamentoProveedor> MedicamentosProveedores { get; set; }
    public DbSet<MovimientoMedicamento> MovimientosMedicamentos { get; set; }
    public DbSet<Propietario> Propietarios { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<Veterinario> Veterinarios { get; set; }
    //db para jwt
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleUser> RolesUsers { get; set; }
    //metodo para aplicar las configuracion de las entidades
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

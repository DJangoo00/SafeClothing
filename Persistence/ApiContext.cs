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
    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Color> Colores { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<DetalleOrden> DetallseOrdenes { get; set; }
    public DbSet<DetalleVenta> DetallesVentas { get; set; }
    public DbSet<Empleado> Empleados { get; set; }
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<FormaPago> FormaPagos { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Insumo> Insumos { get; set; }
    public DbSet<InsumoPrenda> InsumosPrendas { get; set; }
    public DbSet<InsumoProveedor> InsumosProveedores { get; set; }
    public DbSet<Inventario> Inventarios { get; set; }
    public DbSet<InventarioTalla> InventariosTallas { get; set; }
    public DbSet<Municipio> Municipios { get; set; }
    public DbSet<Orden> Ordenes { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Prenda> Prendas { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<Talla> Tallas { get; set; }
    public DbSet<TipoEstado> TiposEstados { get; set; }
    public DbSet<TipoPersona> TiposPersonas { get; set; }
    public DbSet<TipoProteccion> TiposProtecciones { get; set; }
    public DbSet<Venta> Ventas { get; set; }

    
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

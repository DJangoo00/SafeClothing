using Domain.Entities;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    //Entities
    ICargo Cargos { get; }
    ICliente Clientes { get; }
    IColor Colores { get; }
    IDepartamento Departamentos { get; }
    IDetalleOrden DetallesOrdenes { get; }
    IDetalleVenta DetallesVentas { get; }
    IEmpleado Empleados { get; }
    IEmpresa Empresas { get; }
    IEstado Estados { get; }
    IFormaPago FormasPagos { get; }
    IGenero Generos { get; }
    IInsumo Insumos { get; }
    IInsumoPrenda InsumosPrendas { get; }
    IInventario Inventarios { get; }
    IInventarioTalla InventariosTallas { get; }
    IMunicipio Municipios { get; }
    IOrden Ordenes { get; }
    IPais Paises { get; }
    IPrenda Prendas { get; }
    IProveedor Proveedores { get; }
    ITalla Tallas { get; }
    ITipoEstado TiposEstados { get; }
    ITipoPersona TiposPersonas { get; }
    ITipoProteccion TiposProtecciones { get; }
    IVenta Ventas { get; }



    //JWT
    IUserRepository Users { get; }
    IRoleRepository Roles { get; }
    Task<int> SaveAsync();
}

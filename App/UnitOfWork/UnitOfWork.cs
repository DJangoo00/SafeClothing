using App.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    //def entities
    private CargoRepository _cargos;
    private ClienteRepository _clientes;
    private ColorRepository _colores;
    private DepartamentoRepository _departamentos;
    private DetalleOrdenRepository _detallesOrdenes;
    private DetalleVentaRepository _detallesVentas;
    private EmpleadoRepository _empleados;
    private EmpresaRepository _empresas;
    private EstadoRepository _estados;
    private FormaPagoRepository _formasPagos;
    private GeneroRepository _generos;
    private InsumoPrendaRepository _insumosPrendas;
    private InsumoRepository _insumos;
    private InventarioRepository _inventarios;
    private InventarioTallaRepository _inventariosTallas;
    private MunicipioRepository _municipios;
    private OrdenRepository _ordenes;
    private PaisRepository _paises;
    private PrendaRepository _prendas;
    private ProveedorRepository _proveedores;
    private TallaRepository _tallas;
    private TipoEstadoRepository _tiposEstados;
    private TipoPersonaRepository _tiposPersonas;
    private TipoProteccionRepository _tiposProtecciones;
    private VentaRepository _ventas;
    //def jwt
    private readonly ApiContext _context;
    private RoleRepository _roles;
    private UserRepository _users;
    public UnitOfWork(ApiContext context)
    {
        _context = context;
    }
    //entities
    public ICargo Cargos
    {
        get
        {
            if (_cargos == null)
            {
                _cargos = new CargoRepository(_context);
            }
            return _cargos;
        }
    }

    public ICliente Clientes
    {
        get
        {
            if (_clientes == null)
            {
                _clientes = new ClienteRepository(_context);
            }
            return _clientes;
        }
    }
    public IColor Colores
    {
        get
        {
            if (_colores == null)
            {
                _colores = new ColorRepository(_context);
            }
            return _colores;
        }
    }
    public IDepartamento Departamentos
    {
        get
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context);
            }
            return _departamentos;
        }
    }
    public IDetalleOrden DetallesOrdenes
    {
        get
        {
            if (_detallesOrdenes == null)
            {
                _detallesOrdenes = new DetalleOrdenRepository(_context);
            }
            return _detallesOrdenes;
        }
    }
    public IDetalleVenta DetallesVentas
    {
        get
        {
            if (_detallesVentas == null)
            {
                _detallesVentas = new DetalleVentaRepository(_context);
            }
            return _detallesVentas;
        }
    }
    public IEmpleado Empleados
    {
        get
        {
            if (_empleados == null)
            {
                _empleados = new EmpleadoRepository(_context);
            }
            return _empleados;
        }
    }
    public IEmpresa Empresas
    {
        get
        {
            if (_empresas == null)
            {
                _empresas = new EmpresaRepository(_context);
            }
            return _empresas;
        }
    }
    public IEstado Estados
    {
        get
        {
            if (_estados == null)
            {
                _estados = new EstadoRepository(_context);
            }
            return _estados;
        }
    }
    public IFormaPago FormasPagos
    {
        get
        {
            if (_formasPagos == null)
            {
                _formasPagos = new FormaPagoRepository(_context);
            }
            return _formasPagos;
        }
    }
    public IGenero Generos
    {
        get
        {
            if (_generos == null)
            {
                _generos = new GeneroRepository(_context);
            }
            return _generos;
        }
    }
    public IInsumoPrenda InsumosPrendas
    {
        get
        {
            if (_insumosPrendas == null)
            {
                _insumosPrendas = new InsumoPrendaRepository(_context);
            }
            return _insumosPrendas;
        }
    }
    public IInsumo Insumos
    {
        get
        {
            if (_insumos == null)
            {
                _insumos = new InsumoRepository(_context);
            }
            return _insumos;
        }
    }
    public IInventario Inventarios
    {
        get
        {
            if (_inventarios == null)
            {
                _inventarios = new InventarioRepository(_context);
            }
            return _inventarios;
        }
    }

    public IInventarioTalla InventariosTallas
    {
        get
        {
            if (_inventariosTallas == null)
            {
                _inventariosTallas = new InventarioTallaRepository(_context);
            }
            return _inventariosTallas;
        }
    }
    public IMunicipio Municipios
    {
        get
        {
            if (_municipios == null)
            {
                _municipios = new MunicipioRepository(_context);
            }
            return _municipios;
        }
    }
    public IOrden Ordenes
    {
        get
        {
            if (_ordenes == null)
            {
                _ordenes = new OrdenRepository(_context);
            }
            return _ordenes;
        }
    }
    public IPais Paises
    {
        get
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(_context);
            }
            return _paises;
        }
    }
    public IPrenda Prendas
    {
        get
        {
            if (_prendas == null)
            {
                _prendas = new PrendaRepository(_context);
            }
            return _prendas;
        }
    }
    public IProveedor Proveedores
    {
        get
        {
            if (_proveedores == null)
            {
                _proveedores = new ProveedorRepository(_context);
            }
            return _proveedores;
        }
    }
    public ITalla Tallas
    {
        get
        {
            if (_tallas == null)
            {
                _tallas = new TallaRepository(_context);
            }
            return _tallas;
        }
    }
    public ITipoEstado TiposEstados
    {
        get
        {
            if (_tiposEstados == null)
            {
                _tiposEstados = new TipoEstadoRepository(_context);
            }
            return _tiposEstados;
        }
    }
    public ITipoPersona TiposPersonas
    {
        get
        {
            if (_tiposPersonas == null)
            {
                _tiposPersonas = new TipoPersonaRepository(_context);
            }
            return _tiposPersonas;
        }
    }
    public ITipoProteccion TiposProtecciones
    {
        get
        {
            if (_tiposProtecciones == null)
            {
                _tiposProtecciones = new TipoProteccionRepository(_context);
            }
            return _tiposProtecciones;
        }
    }

    public IVenta Ventas
    {
        get
        {
            if (_ventas == null)
            {
                _ventas = new VentaRepository(_context);
            }
            return _ventas;
        }
    }


    //jwt
    public IRoleRepository Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RoleRepository(_context);
            }
            return _roles;
        }
    }

    public IUserRepository Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepository(_context);
            }
            return _users;
        }
    }

    public int Save()
    {
        return _context.SaveChanges();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}
using Domain.Entities;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    IMascotaRepository Mascotas { get; }
    IMedicamentoRepository Medicamentos { get; }
    IMovimientoMedicamentoRepository MovimientosMedicamentos { get; }
    IPropietarioRepository Propietarios { get; }
    IProveedorRepository Proveedores { get; }
    IRoleRepository Roles { get; }
    IVeterinarioRepository Veterinarios { get; }
    
    //JWT
    IUserRepository Users { get; }

    Task<int> SaveAsync();
}

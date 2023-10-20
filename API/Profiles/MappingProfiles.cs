using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Mascota, MascotaDto>().ReverseMap();
        CreateMap<Medicamento, MedicamentoDto>().ReverseMap();
        CreateMap<MovimientoMedicamento, MovimientoMedicamentoDto>().ReverseMap();
        CreateMap<Propietario, PropietarioDto>().ReverseMap();
        CreateMap<Proveedor, ProveedorDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Veterinario, VeterinarioDto>().ReverseMap();
    }
}

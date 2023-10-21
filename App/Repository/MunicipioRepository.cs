using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class MunicipioRepository : GenericRepository<Municipio>, IMunicipio
    {
        private readonly ApiContext _context;
    public MunicipioRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    }
}
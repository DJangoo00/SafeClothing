using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository;
public class EmpresaRepository : GenericRepository<Empresa>, IEmpresa
{
    private readonly ApiContext _context;
    public EmpresaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
}
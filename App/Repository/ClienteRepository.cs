using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository;
public class ClienteRepository : GenericRepository<Cliente>, ICliente
{
    private readonly ApiContext _context;
    public ClienteRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
}
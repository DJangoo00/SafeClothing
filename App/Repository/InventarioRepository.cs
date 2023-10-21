using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class InventarioRepository : GenericRepository<Inventario>, IInventario
    {
        private readonly ApiContext _context;
    public InventarioRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    }
}
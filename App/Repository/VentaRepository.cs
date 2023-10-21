using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class VentaRepository : GenericRepository<Venta>, IVenta
    {
        private readonly ApiContext _context;
    public VentaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    }
}
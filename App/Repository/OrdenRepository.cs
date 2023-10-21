using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class OrdenRepository : GenericRepository<Orden>, IOrden
    {
        private readonly ApiContext _context;
    public OrdenRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    }
}
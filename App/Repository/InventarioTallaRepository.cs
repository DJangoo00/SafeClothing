using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class InventarioTallaRepository : GenericRepository<InventarioTalla>, IInventarioTalla
    {
        private readonly ApiContext _context;
        public InventarioTallaRepository(ApiContext context) : base(context)
        {
            _context = context;
        }
    }
}
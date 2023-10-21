using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class InsumoPrendaRepository : GenericRepository<InsumoPrenda>, IInsumoPrenda
    {
        private readonly ApiContext _context;
    public InsumoPrendaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    }
}
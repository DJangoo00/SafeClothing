using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class TallaRepository : GenericRepository<Talla>, ITalla
    {
        private readonly ApiContext _context;
    public TallaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
    }
}
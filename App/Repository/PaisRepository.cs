using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class PaisRepository : GenericRepository<Pais>, IPais
    {
        private readonly ApiContext _context;
        public PaisRepository(ApiContext context) : base(context)
        {
            _context = context;
        }
    }
}
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class EstadoRepository : GenericRepository<Estado>, IEstado
    {
        private readonly ApiContext _context;
        public EstadoRepository(ApiContext context) : base(context)
        {
            _context = context;
        }
    }
}
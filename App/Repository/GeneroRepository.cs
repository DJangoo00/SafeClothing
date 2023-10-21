using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository
{
    public class GeneroRepository : GenericRepository<Genero>, IGenero
    {
        private readonly ApiContext _context;
        public GeneroRepository(ApiContext context) : base(context)
        {
            _context = context;
        }
    }
}
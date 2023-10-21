using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository;
public class CargoRepository : GenericRepository<Cargo>, ICargo
{
    private readonly ApiContext _context;
    public CargoRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
}
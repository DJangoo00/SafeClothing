using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace App.Repository;
public class ColorRepository : GenericRepository<Color>, IColor
{
    private readonly ApiContext _context;
    public ColorRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
}

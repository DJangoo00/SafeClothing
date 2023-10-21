using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;
using App.Repository;

namespace Domain.Interfaces;
public class DetalleOrdenRepository : GenericRepository<DetalleOrden>, IDetalleOrden
{
    private readonly ApiContext _context;
    public DetalleOrdenRepository(ApiContext context) : base(context)
    {
        _context = context;
    }
}
using App.Repository;
using Domain.Interfaces;
using Persistence;

namespace App.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApiContext _context;
    private RoleRepository _roles;
    private UserRepository _users;
    public UnitOfWork(ApiContext context)
    {
        _context = context;
    }
    
    //jwt
    public IRoleRepository Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RoleRepository(_context);
            }
            return _roles;
        }
    }

    public IUserRepository Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepository(_context);
            }
            return _users;
        }
    }

    public int Save()
    {
        return _context.SaveChanges();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}
using Domain.Entities;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    
    
    //JWT
    IUserRepository Users { get; }
    IRoleRepository Roles { get; }
    Task<int> SaveAsync();
}

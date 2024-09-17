using System;
using System.Threading.Tasks;
using Services.Repositories.IRepositories;

namespace Services.IServices;

public interface IUnitOfWork : IDisposable
{
    IModel1Repository Model1Repository { get; }
    IModel2Repository Model2Repository { get; }
    IModel3Repository Model3Repository { get; }

    Task<bool> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}

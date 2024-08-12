using Services.Repositories.IRepositories;

namespace Services.IServices;

public interface IUnitOfWork
{
    IModel1Repository Model1Repository { get; }
    IModel2Repository Model2Repository { get; }
    IModel3Repository Model3Repository { get; }
    void SaveChanges();
}

using Services.Repositories.IRepositories;

namespace Services.IServices;

public interface IUnitOfWork
{
    IModel1Repository model1Repository { get; }
    IModel2Repository model2Repository { get; }
    IModel3Repository model3Repository { get; }
    void SaveChanges();
}

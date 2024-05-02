using Data;
using Services.IServices;
using Services.Repositories;
using Services.Repositories.IRepositories;

namespace Services;

public class UnitOfWork : IUnitOfWork
{
    private readonly DatabaseContext _databaseContext;

    public UnitOfWork(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;

        model1Repository = new Model1Repository(_databaseContext);
        model2Repository = new Model2Repository(_databaseContext);
        model3Repository = new Model3Repository(_databaseContext);
    }

    public IModel1Repository model1Repository { get; private set; }

    public IModel2Repository model2Repository { get; private set; }

    public IModel3Repository model3Repository { get; private set; }

    public void SaveChanges()
    {
        _databaseContext.SaveChanges();
    }
}

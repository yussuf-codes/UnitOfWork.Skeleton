using Data;
using Services.IServices;
using Services.Repositories;
using Services.Repositories.IRepositories;

namespace Services;

public class UnitOfWork : IUnitOfWork
{
    public IModel1Repository Model1Repository { get; private set; }
    public IModel2Repository Model2Repository { get; private set; }
    public IModel3Repository Model3Repository { get; private set; }

    private readonly DatabaseContext _databaseContext;

    public UnitOfWork
    (
        DatabaseContext databaseContext,
        Model1Repository model1,
        Model2Repository model2,
        Model3Repository model3
    )
    {
        _databaseContext = databaseContext;

        Model1Repository = model1;
        Model2Repository = model2;
        Model3Repository = model3;
    }

    public void SaveChanges()
    {
        _databaseContext.SaveChanges();
    }
}

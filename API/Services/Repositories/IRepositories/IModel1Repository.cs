using Models;

namespace Services.Repositories.IRepositories;

public interface IModel1Repository : IGenericRepository<Model1>
{
    void CustomBehavior1(Model1 obj);
}

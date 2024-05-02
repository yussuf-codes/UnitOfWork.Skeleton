using Models;

namespace Services.Repositories.IRepositories;

public interface IModel3Repository : IGenericRepository<Model3>
{
    void CustomBehavior3();
}

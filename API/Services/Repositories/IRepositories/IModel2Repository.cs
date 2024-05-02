using Models;

namespace Services.Repositories.IRepositories;

public interface IModel2Repository : IGenericRepository<Model2>
{
    void CustomBehavior2();
}

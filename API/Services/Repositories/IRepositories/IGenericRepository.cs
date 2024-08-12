namespace Services.Repositories.IRepositories;

using System.Collections.Generic;

public interface IGenericRepository<T>
{
    object Add(T obj);
    void Delete(int id);
    bool Exists(int id);
    IEnumerable<T> Get();
    T? Get(int id);
    void Update(int id, T obj);
}

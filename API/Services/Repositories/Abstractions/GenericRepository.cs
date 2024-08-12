using System;
using System.Collections.Generic;

using Data;
using Models.Abstractions;
using Services.Repositories.IRepositories;

namespace Services.Repositories.Abstractions;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
{
    protected readonly DatabaseContext _databaseContext;

    public GenericRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    virtual public object Add(T obj)
    {
        throw new NotImplementedException();
    }

    virtual public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    virtual public bool Exists(int id)
    {
        throw new NotImplementedException();
    }

    virtual public IEnumerable<T> Get()
    {
        throw new NotImplementedException();
    }

    virtual public T? Get(int id)
    {
        throw new NotImplementedException();
    }

    virtual public void Update(int id, T obj)
    {
        throw new NotImplementedException();
    }
}

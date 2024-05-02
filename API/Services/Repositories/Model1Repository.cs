using System;

using Data;
using Models;
using Services.Repositories.Abstractions;
using Services.Repositories.IRepositories;

namespace Services.Repositories;

public class Model1Repository : GenericRepository<Model1>, IModel1Repository
{
    public Model1Repository(DatabaseContext databaseContext) : base(databaseContext)
    {

    }

    public override void Add(Model1 obj)
    {
        // Doing some custom behavior
        _databaseContext.Entities1.Add(obj);
        // Doing some custom behavior
    }

    public void CustomBehavior1(Model1 obj)
    {
        throw new NotImplementedException();
    }
}

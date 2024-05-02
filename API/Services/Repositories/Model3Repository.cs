using System;

using Data;
using Models;
using Services.Repositories.Abstractions;
using Services.Repositories.IRepositories;

namespace Services.Repositories;

public class Model3Repository : GenericRepository<Model3>, IModel3Repository
{
    public Model3Repository(DatabaseContext databaseContext) : base(databaseContext)
    {

    }

    public override void Add(Model3 obj)
    {
        // Doing some custom behavior
        _databaseContext.Entities3.Add(obj);
        // Doing some custom behavior
    }

    public void CustomBehavior3()
    {
        throw new NotImplementedException();
    }
}

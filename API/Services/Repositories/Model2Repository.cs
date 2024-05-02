using System;

using Data;
using Models;
using Services.Repositories.Abstractions;
using Services.Repositories.IRepositories;

namespace Services.Repositories;

public class Model2Repository : GenericRepository<Model2>, IModel2Repository
{
    public Model2Repository(DatabaseContext databaseContext) : base(databaseContext)
    {

    }

    public override void Add(Model2 obj)
    {
        // Doing some custom behavior
        _databaseContext.Entities2.Add(obj);
        // Doing some custom behavior
    }

    public void CustomBehavior2()
    {
        throw new NotImplementedException();
    }
}

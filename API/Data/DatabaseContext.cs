using Microsoft.EntityFrameworkCore;

using Models;

namespace Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    public DbSet<Model1> Entities1 { get; set; }
    public DbSet<Model2> Entities2 { get; set; }
    public DbSet<Model3> Entities3 { get; set; }
}

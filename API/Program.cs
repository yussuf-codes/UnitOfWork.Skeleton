using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Data;
using Services;
using Services.IServices;

namespace API;

public class Program
{
    public static void Main()
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder();

        builder.Services.AddControllers();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

        string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));

        WebApplication app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}

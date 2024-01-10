using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrainTicketManagement.Application.Common.Interfaces;

namespace TrainTicketManagement.Persistance;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistance(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<UserDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("UserDatabase")));

        services.AddScoped<IUserDbContext, UserDbContext>();
        return services;
        
    }
}
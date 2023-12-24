using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrainTicketManagement.Application.Common.Interfaces;
using TrainTicketManagement.Infrastructure.FileStore;
using TrainTicketManagement.Infrastructure.Services;

namespace TrainTicketManagement.Infrastructure
{
    public static class DependencyInjection
    {

        
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IFileStore,FileStore.FileStore>();
            services.AddTransient<IFileWrapper,FileWrapper>();
            services.AddTransient<IDirectoryWrapper,DirectoryWrapper>();
            return services;
        }
          
        
        
    }
}

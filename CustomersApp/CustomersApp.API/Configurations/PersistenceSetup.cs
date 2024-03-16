using CustomersApp.Domain.Repositories;
using CustomersApp.Infrastructure.Repositories;

namespace CustomersApp.API.Configurations
{
    public static class PersistenceSetup
    {
        public static IServiceCollection AddPersistenceSetup(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}

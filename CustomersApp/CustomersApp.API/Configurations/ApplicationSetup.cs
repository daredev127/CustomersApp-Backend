using CustomersApp.Application.MappingProfiles;
using CustomersApp.Application.Services.GetAllCustomers;

namespace CustomersApp.API.Configurations
{
    public static class ApplicationSetup
    {
        public static IServiceCollection AddApplicationSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CustomerMappingProfile));

            services.AddScoped<IGetAllCustomersService, GetAllCustomersService>();

            return services;
        }
    }
}

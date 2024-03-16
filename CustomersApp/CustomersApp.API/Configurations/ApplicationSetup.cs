using CustomersApp.Application.MappingProfiles;

namespace CustomersApp.API.Configurations
{
    public static class ApplicationSetup
    {
        public static IServiceCollection AddApplicationSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CustomerMappingProfile));

            return services;
        }
    }
}

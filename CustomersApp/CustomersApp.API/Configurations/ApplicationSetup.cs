using CustomersApp.Application.DataValidation;
using CustomersApp.Application.MappingProfiles;
using CustomersApp.Application.Services.AddCustomer;
using CustomersApp.Application.Services.GetAllCustomers;

namespace CustomersApp.API.Configurations
{
    public static class ApplicationSetup
    {
        public static IServiceCollection AddApplicationSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CustomerMappingProfile));

            services.AddScoped<IGetAllCustomersService, GetAllCustomersService>();
            services.AddScoped<IAddCustomerService, AddCustomerService>();

            services.AddScoped<IValidationService, ValidationService>();

            return services;
        }
    }
}

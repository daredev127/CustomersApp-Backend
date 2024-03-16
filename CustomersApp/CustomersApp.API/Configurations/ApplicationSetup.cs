using CustomersApp.API.Middlewares;
using CustomersApp.Application.DataValidation;
using CustomersApp.Application.MappingProfiles;
using CustomersApp.Application.Services.AddCustomer;
using CustomersApp.Application.Services.GetAllCustomers;
using CustomersApp.Application.Services.GetCustomer;

namespace CustomersApp.API.Configurations
{
    public static class ApplicationSetup
    {
        public static IServiceCollection AddApplicationSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CustomerMappingProfile));
            services.AddTransient<ExceptionHandlingMiddleware>();

            services.AddScoped<IGetAllCustomersService, GetAllCustomersService>();
            services.AddScoped<IAddCustomerService, AddCustomerService>();
            services.AddScoped<IGetCustomerService, GetCustomerService>();

            services.AddScoped<IValidationService, ValidationService>();

            return services;
        }
    }
}

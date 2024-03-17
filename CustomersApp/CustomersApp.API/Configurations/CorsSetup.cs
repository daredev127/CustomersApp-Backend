namespace CustomersApp.API.Configurations
{
    public static class CorsSetup
    {
        public static IServiceCollection AddCorsSetup(this IServiceCollection services, string policyName)
        {
            services.AddCors(options =>
                options.AddPolicy(name: policyName,
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                }));

            return services;
        }
    }
}

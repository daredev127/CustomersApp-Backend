using CustomersApp.API.Middlewares;

namespace CustomersApp.API.Configurations
{
    public static class ErrorHandlingSetup
    {
        public static IApplicationBuilder SetupErrorHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}

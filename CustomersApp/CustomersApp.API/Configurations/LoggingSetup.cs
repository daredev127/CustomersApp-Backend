using Serilog;

namespace CustomersApp.API.Configurations
{
    public static class LoggingSetup
    {
        public static IHostBuilder UseLoggingSetup(this IHostBuilder host, IConfiguration configuration)
        {
            object value = host.UseSerilog((context, config) =>
            {
                config.ReadFrom.Configuration(configuration);
            });

            return host;
        }
    }
}

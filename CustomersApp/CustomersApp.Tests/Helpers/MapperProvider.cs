using AutoMapper;
using CustomersApp.Application.MappingProfiles;

namespace CustomersApp.Tests.Helpers
{
    public static class MapperProvider
    {
        public static IMapper Provide()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CustomerMappingProfile());
            });
            return config.CreateMapper();
        }
    }
}

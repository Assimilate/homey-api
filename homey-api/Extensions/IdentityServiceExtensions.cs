using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace homey_api.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config) 
        {
            return services; // Not yet implemented.
        }
    }
}
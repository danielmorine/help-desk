using Microsoft.Extensions.DependencyInjection;

namespace HelpDeskAPI.Web.Extensions.IOC
{
    public static class ServiceInjection
    {
        public static IServiceCollection ServiceIOC(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}

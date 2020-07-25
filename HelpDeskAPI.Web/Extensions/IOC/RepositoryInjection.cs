using Microsoft.Extensions.DependencyInjection;

namespace HelpDeskAPI.Web.Extensions.IOC
{
    public static class RepositoryInjection
    {
        public static IServiceCollection RepositoryIOC(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}

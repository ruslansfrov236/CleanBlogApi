using CleanBlog.App.Applications;
using CleanBlog.Infrastructure.Applications;
using Microsoft.Extensions.DependencyInjection;

namespace CleanBlog.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddCleanBlogServiceRegistrationInfrastructure(this IServiceCollection service)
        {
            service.AddScoped<IStorageService, StorageService>();
            
        }

    
    }
}

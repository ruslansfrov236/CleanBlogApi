using CleanBlog.App.Applications;
using CleanBlog.Infrastructure.Applications;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddCleanBlogServiceRegistrationInfrastructure(this IServiceCollection service)
        {
             service.AddTransient<IStorageService, StorageService>();   
        }
    }
}

using CleanBlog.App.Applications.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App
{
    public static  class ServiceRegistration
    {
        public static void AddCleanBlogServiceRegistrationApp(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceRegistration));
            services.AddHttpClient();
        }
    }
}

using CleanBlog.App.Applications.Services;
using CleanBlog.App.Repository;
using CleanBlog.Persistence.Context;
using CleanBlog.Persistence.Repository;
using CleanBlog.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddCleanBlogServiceRegistrationPersistence(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration.ConnectionString)
                .EnableSensitiveDataLogging();
            });


            services.AddScoped<IAboutReadRepository, AboutReadRepository>();
            services.AddScoped<IAboutWriteRepository, AboutWriteRepository>();
            services.AddScoped<IContactDescriptionReadRepository, ContactsDescriptionReadRepository>();
            services.AddScoped<IContactDescriptionWriteRepository, ContactsDescriptionWriteRepository>();
            services.AddScoped<IHeaderReadRepository, HeaderReadRepository>();
            services.AddScoped<IHeaderWriteRepository, HeaderWriteRepository>();
            services.AddScoped<IMessageReadRepository, MessageReadRepository>();
            services.AddScoped<IMessageWriteRepository, MessageWriteRepository>();
            services.AddScoped<IPostReadRepository, PostReadRepository>();
            services.AddScoped<IPostWriteRepository, PostsWriteRepository>();


            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IHeaderService, HeaderService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IContactsDescriptionService, ContactsDescriptionService>();
            services.AddScoped<IPostsService, PostService>();
        }

    }
}

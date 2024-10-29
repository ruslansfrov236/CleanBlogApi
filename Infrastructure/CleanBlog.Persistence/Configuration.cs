using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace CleanBlog.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {

            get
            {
                ConfigurationManager configurationManager = new();
                try
                {
                    
                    var extension = "../../Presentition/CleanBlog.Api";
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), extension));
                    configurationManager.AddJsonFile("appsettings.json");
                }
                catch
                {
                    configurationManager.AddJsonFile("appsettings.json");
                }

                return configurationManager.GetConnectionString("SQLServer");
            }
        }
    }
}
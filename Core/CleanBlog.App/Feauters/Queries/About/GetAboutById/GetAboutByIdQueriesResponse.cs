using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C=CleanBlog.Domain.Entities;
namespace CleanBlog.App.Feauters.Queries.About.GetAboutById
{
    public class GetAboutByIdQueriesResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } 

        public object About { get; set; }    
    }
}

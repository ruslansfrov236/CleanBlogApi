using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Posts.GetPostsAll
{
    public class GetPostAllQueriesResponse
    {
        public bool Success { get; set; }   

        public string Message { get; set; } 

        public object Posts { get; set; }   
    }
}

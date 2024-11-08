using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.PostRead.GetPostReadById
{
    public class GetPostReadByIdQueriesResponse
    {
        public bool Success { get; set; }   
        public string Message { get; set; } 

        public object PostRead {  get; set; }   
    }
}

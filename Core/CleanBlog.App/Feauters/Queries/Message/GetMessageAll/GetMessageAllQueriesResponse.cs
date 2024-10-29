using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Message.GetMessageAll
{
    public class GetMessageAllQueriesResponse
    {
        public bool Success { get; set; }   

        public string Message { get; set; } 
        public object Messages { get; set; }    
    }
}

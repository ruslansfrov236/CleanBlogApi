using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Header.GetHeaderAll
{
    public class GetHeaderAllQueriesResponse
    {
        public bool Success { get; set; }   

        public string Message { get; set; } 
        public object Header { get; set; }  
    }
}

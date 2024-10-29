using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Message.GetMessageById
{
    public class GetMessageByIdQueriesResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Messages { get; set; }
    }
}

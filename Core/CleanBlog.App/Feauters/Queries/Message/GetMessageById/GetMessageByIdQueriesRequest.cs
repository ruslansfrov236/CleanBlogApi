using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Message.GetMessageById
{
    public class GetMessageByIdQueriesRequest:IRequest<GetMessageByIdQueriesResponse>   
    {
        public string id { get; set; }  
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.PostRead.GetPostReadById
{
    public class GetPostReadByIdQueriesRequest:IRequest<GetPostReadByIdQueriesResponse> 
    {
        public string id { get; set; }  
    }
}

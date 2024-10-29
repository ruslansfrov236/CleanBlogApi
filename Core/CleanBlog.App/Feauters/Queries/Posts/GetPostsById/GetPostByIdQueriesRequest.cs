using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Posts.GetPostsById
{
    public class GetPostByIdQueriesRequest:IRequest<GetPostByIdQueriesResponse> 
    {
        public string id { get; set; }  
    }
}

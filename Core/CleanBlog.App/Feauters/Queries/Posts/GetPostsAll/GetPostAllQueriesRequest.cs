using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Posts.GetPostsAll
{
    public class GetPostAllQueriesRequest:IRequest<GetPostAllQueriesResponse>   
    {
        public int Page { get; set; } = 0;
         public int Size { get; set; } = 5;
    }
}

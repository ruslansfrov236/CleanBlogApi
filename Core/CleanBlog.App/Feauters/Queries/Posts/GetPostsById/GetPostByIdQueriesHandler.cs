using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Posts.GetPostsById
{
    public class GetPostByIdQueriesHandler : IRequestHandler<GetPostByIdQueriesRequest, GetPostByIdQueriesResponse>
    {
        readonly private IPostsService _postsService;

        public GetPostByIdQueriesHandler(IPostsService postsService)=> _postsService= postsService; 
     
        public async Task<GetPostByIdQueriesResponse> Handle(GetPostByIdQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
            var post =  await  _postsService.GetById(request.id);

                return new GetPostByIdQueriesResponse()
                {
                    Success = true,
                    Message = string.Empty,
                    Posts=post
                };
            }
            catch (Exception ex)
            {
                return new GetPostByIdQueriesResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}

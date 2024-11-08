using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Posts.GetPostsAll
{
    public class GetPostAllQueriesHandler : IRequestHandler<GetPostAllQueriesRequest, GetPostAllQueriesResponse>
    {
        readonly private IPostsService _postsService;
        public GetPostAllQueriesHandler(IPostsService postsService) => _postsService = postsService;

        public async Task<GetPostAllQueriesResponse> Handle(GetPostAllQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
             var post =   await _postsService.GetAll(request.Size, request.Page);

                return new GetPostAllQueriesResponse()
                {
                    Success = true,
                    Message=string.Empty,
                    Posts=post,
                    PostCount=post.Count(),

                };
            }
            catch (Exception ex)
            {
                return new GetPostAllQueriesResponse()
                {
                    Success = false,
                    Message = ex.Message,
                };
            }
        }
    }
}

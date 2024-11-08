using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.PostRead.GetPostReadAll
{
    public class GetPostReadAllQueriesHandler : IRequestHandler<GetPostReadAllQueriesRequest, GetPostReadAllQueriesResponse>
    {
        readonly private IPostReadService _postReadService;

        public GetPostReadAllQueriesHandler(IPostReadService postReadService)
        {
            _postReadService= postReadService;
        }
        async Task<GetPostReadAllQueriesResponse> IRequestHandler<GetPostReadAllQueriesRequest, GetPostReadAllQueriesResponse>.Handle(GetPostReadAllQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
              var postRead=   await _postReadService.GetAll();
                return new GetPostReadAllQueriesResponse()
                {
                    Success = true,
                    Message = string.Empty,
                    PostRead = postRead
                    
                };
            }
            catch (Exception ex)
            {
                return new GetPostReadAllQueriesResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}

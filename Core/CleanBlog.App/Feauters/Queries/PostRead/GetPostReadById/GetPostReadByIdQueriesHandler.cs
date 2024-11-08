using CleanBlog.App.Applications.Services;
using CleanBlog.App.Feauters.Queries.PostRead.GetPostReadAll;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.PostRead.GetPostReadById
{
    public class GetPostReadByIdQueriesHandler : IRequestHandler<GetPostReadByIdQueriesRequest, GetPostReadByIdQueriesResponse>
    {
        readonly private IPostReadService _postReadService;

        public GetPostReadByIdQueriesHandler(IPostReadService postReadService)
        {
            _postReadService = postReadService; 
        }
        public async Task<GetPostReadByIdQueriesResponse> Handle(GetPostReadByIdQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
             var postRead =   await _postReadService.GetAll();
                return new GetPostReadByIdQueriesResponse()
                {
                    Success = true,
                    Message = string.Empty,
                    PostRead= postRead  
                };
            }
            catch (Exception ex)
            {
                return new GetPostReadByIdQueriesResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}

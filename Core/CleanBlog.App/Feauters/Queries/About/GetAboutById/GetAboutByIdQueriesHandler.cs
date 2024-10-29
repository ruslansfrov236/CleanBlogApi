using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.About.GetAboutById
{
    public class GetAboutByIdQueriesHandler : IRequestHandler<GetAboutByIdQueriesRequest, GetAboutByIdQueriesResponse>
    {
        readonly private IAboutService _aboutService;

        public GetAboutByIdQueriesHandler(IAboutService aboutService) { _aboutService = aboutService; }

        public async Task<GetAboutByIdQueriesResponse> Handle(GetAboutByIdQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
               var about =  await _aboutService.GetById(request.id);
                return new GetAboutByIdQueriesResponse()
                {
                    Success = true,
                    Message = String.Empty,
                    About= about
                    
                };
            }
            catch (Exception ex)
            {
                {
                    return new GetAboutByIdQueriesResponse()
                    {
                        Success = false,
                        Message = ex.Message
                    };
                }
            }
        }
    }
}

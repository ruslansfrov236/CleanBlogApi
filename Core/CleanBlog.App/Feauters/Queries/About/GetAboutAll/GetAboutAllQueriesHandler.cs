using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.About.GetAboutAll
{
    public class GetAboutAllQueriesHandler : IRequestHandler<GetAboutAllQueriesRequest, GetAboutAllQueriesResponse>
    {
        readonly private IAboutService _aboutService;

        public GetAboutAllQueriesHandler(IAboutService aboutService)=> _aboutService = aboutService;    
        
        async Task<GetAboutAllQueriesResponse> IRequestHandler<GetAboutAllQueriesRequest, GetAboutAllQueriesResponse>.Handle(GetAboutAllQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
            var data = await _aboutService.GetAll();

                return new GetAboutAllQueriesResponse()
                {
                    Success = true,
                    Message = string.Empty, 
                      About = data
                };

            }
            catch (Exception ex) {

                return new GetAboutAllQueriesResponse()
                {
                    Success = true,
                    Message = ex.Message,
                  
                    
                };
            }
        }
    }
}

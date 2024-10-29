using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Header.GetHeaderAll
{
    public class GetHeaderAllQueriesHandler : IRequestHandler<GetHeaderAllQueriesRequest, GetHeaderAllQueriesResponse>
    {
        readonly private IHeaderService _headerService;

        public GetHeaderAllQueriesHandler(IHeaderService headerService) => _headerService = headerService;

        public async Task<GetHeaderAllQueriesResponse> Handle(GetHeaderAllQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
               var header =  await _headerService.GetAll();
                return new GetHeaderAllQueriesResponse()
                {
                    Success = true,
                    Message= string.Empty   ,
                    Header= header
                };
            }

            catch (Exception ex)
            {
                return new GetHeaderAllQueriesResponse()
                {
                    Success = false,
                    Message = ex.Message    
                }; 
            }
        }
    }
}

using CleanBlog.App.Applications.Services;
using CleanBlog.App.Feauters.Queries.Header.GetHeaderAll;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Header.GetHeaderById
{
    public class GetHeaderByIdQueriuesHandler : IRequestHandler<GetHeaderByIdQueriuesRequest, GetHeaderByIdQueriuesResponse>
    {
        readonly private IHeaderService _headerService;

        public GetHeaderByIdQueriuesHandler(IHeaderService headerService) => _headerService = headerService;

        public async Task<GetHeaderByIdQueriuesResponse> Handle(GetHeaderByIdQueriuesRequest request, CancellationToken cancellationToken)
        {
            try
            {
              var header =  await _headerService.GetById(request.id);
                return new GetHeaderByIdQueriuesResponse()
                {
                    Success = true,
                    Message = string.Empty,
                    Header = header
                };
            }

            catch (Exception ex)
            {
                return new GetHeaderByIdQueriuesResponse()
                {
                    Success = false,
                    Message = ex.Message
                }; ;
            }
        }
    }
}

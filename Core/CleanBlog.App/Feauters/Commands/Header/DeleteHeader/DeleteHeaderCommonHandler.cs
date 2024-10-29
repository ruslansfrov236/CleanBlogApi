using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Header.DeleteHeader
{
    public class DeleteHeaderCommonHandler : IRequestHandler<DeleteHeaderCommonRequest, DeleteHeaderCommonResponse>
    {
        readonly private IHeaderService _headerService;


        public DeleteHeaderCommonHandler(IHeaderService headerService) => _headerService = headerService;

        public async Task<DeleteHeaderCommonResponse> Handle(DeleteHeaderCommonRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _headerService.Delete(request.id);

                return new DeleteHeaderCommonResponse()
                {
                    Success = true,
                    Message= "Header deleted successfully"
                };
            }
            catch (Exception ex)
            {
                return new DeleteHeaderCommonResponse()
                {
                    Success = false,
                    Message = ex.Message,
                };
            }
        }
    }
}

using CleanBlog.App.Applications.Services;
using CleanBlog.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Header.UpdateHeader
{
    public class UpdateHeaderCommonHandler : IRequestHandler<UpdateHeaderCommonRequest, UpdateHeaderCommonResponse>
    {
        readonly private IHeaderService _headerService;
        public UpdateHeaderCommonHandler(IHeaderService headerService) { _headerService = headerService; }

        public async Task<UpdateHeaderCommonResponse> Handle(UpdateHeaderCommonRequest request, CancellationToken cancellationToken)
        {
         

            try
            {
                await _headerService.Update(request.UpdateHeaderDto);

                return new UpdateHeaderCommonResponse()
                {
                    Success= true,
                    Message= "Header updated successfully."
                };

            }
            catch (Exception ex)
            {
                return new UpdateHeaderCommonResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
                

            }
        }
    }
}

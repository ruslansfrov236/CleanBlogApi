using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.PostRead.DeletePostRead
{
    public class DeletePostReadCommonHandler : IRequestHandler<DeletePostReadCommonRequest, DeletePostReadCommonResponse>
    {
        readonly private IPostReadService _postReadService;
        public async Task<DeletePostReadCommonResponse> Handle(DeletePostReadCommonRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _postReadService.Delete(request.id);
                return new DeletePostReadCommonResponse()
                {

                    Success = true, 
                    Message= "Post Read deleted successfully"
                };

            }
            catch (Exception ex)
            {
                return new DeletePostReadCommonResponse()
                {
                    Success= false,
                    Message= ex.Message,    
                };
            }
        }
    }
}

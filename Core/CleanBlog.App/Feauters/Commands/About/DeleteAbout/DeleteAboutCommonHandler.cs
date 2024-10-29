using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.About.DeleteAbout
{
    public class DeleteAboutCommonHandler : IRequestHandler<DeleteAboutCommonRequest, DeleteAboutCommonResponse>
    {
        readonly private IAboutService _aboutService;
        public DeleteAboutCommonHandler(IAboutService aboutService) => _aboutService = aboutService;


        public async Task<DeleteAboutCommonResponse> Handle(DeleteAboutCommonRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _aboutService.Delete(request.id);

                return new DeleteAboutCommonResponse()
                {
                    Success = true,
                    Message = "About deleted successfully"
                };
            }
            catch (Exception ex)
            {
                return new DeleteAboutCommonResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}

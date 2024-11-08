using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.About.UpdateAbout
{
    public class UpdateAboutCommonHandler : IRequestHandler<UpdateAboutCommonRequest, UpdateAboutCommonResponse>
    {
        readonly private IAboutService _aboutService;

        public UpdateAboutCommonHandler(IAboutService aboutService) => _aboutService = aboutService;


        public async Task<UpdateAboutCommonResponse> Handle(UpdateAboutCommonRequest request, CancellationToken cancellationToken)
        {
           

            try
            {
                await _aboutService.Update(new Dto_s.About.UpdateAboutDto() {Id=request.Id, Description = request.Description });
                return new UpdateAboutCommonResponse()
                {
                    Success = true,
                    Message= "About updated successfully"
                };
            }
            catch (Exception ex)
            {

                return new UpdateAboutCommonResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}

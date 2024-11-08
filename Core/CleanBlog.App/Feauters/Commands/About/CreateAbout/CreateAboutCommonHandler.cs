using CleanBlog.App.Applications.Services;
using MediatR;
using C=CleanBlog.Domain.Entities;
namespace CleanBlog.App.Feauters.Commands.About.CreateAbout
{
    public class CreateAboutCommonHandler : IRequestHandler<CreateAboutCommonRequest, CreateAboutCommonResponse>


    {
        readonly private IAboutService _aboutService;
        public CreateAboutCommonHandler(IAboutService aboutService)
        {
            _aboutService = aboutService;   
        }
        async Task<CreateAboutCommonResponse> IRequestHandler<CreateAboutCommonRequest, CreateAboutCommonResponse>.Handle(CreateAboutCommonRequest request, CancellationToken cancellationToken)
        {


            try
            {
                await _aboutService.Create(new Dto_s.About.CreateAboutDto() { Description=request.Description });


                return new CreateAboutCommonResponse()
                {
                    Success = true,
                    Message = "About  created successfully."
                };
            }
            catch (Exception ex) {

                return new CreateAboutCommonResponse()
                {
                    Success = false,
                    Message = ex.Message    
                };
            }
        }
    }
}

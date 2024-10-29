using CleanBlog.App.Dto_s.About;
using MediatR;

namespace CleanBlog.App.Feauters.Commands.About.CreateAbout
{
    public class CreateAboutCommonRequest : IRequest<CreateAboutCommonResponse>
    {
       public CreateAboutDto CreateAboutDto { get; set; }   
    }
}

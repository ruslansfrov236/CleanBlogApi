using CleanBlog.App.Applications.Services;
using CleanBlog.App.Feauters.Commands.Posts.CreatePosts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Header.CreateHeader
{
    public class CreateHeaderCommonHandler : IRequestHandler<CreateHeaderCommonRequest, CreateHeaderCommonResponse>
    {
        readonly private IHeaderService _headerService;

        public CreateHeaderCommonHandler(IHeaderService headerService) => _headerService = headerService;

        public async Task<CreateHeaderCommonResponse> Handle(CreateHeaderCommonRequest request, CancellationToken cancellationToken)
        {

            try
            {
                await _headerService.Create(new Dto_s.Header.CreateHeaderDto()
                {
                    Description = request.Description,
                   
                    PageNumber = request.PageNumber,
                    FileName = request.FileName,
                    Title = request.Title,
                    formFile=request.File

                });

                return new CreateHeaderCommonResponse
                {

                    Success = true,
                    Message = "Header created successfully."
                };
            }
            catch (Exception ex)
            {
             
                return new CreateHeaderCommonResponse
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}

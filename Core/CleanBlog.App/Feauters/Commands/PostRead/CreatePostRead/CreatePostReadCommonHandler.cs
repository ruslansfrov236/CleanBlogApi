using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.PostRead.CreatePostRead
{
    public class CreatePostReadCommonHandler : IRequestHandler<CreatePostReadCommonRequest, CreatePostReadCommonResponse>
    {
        readonly private IPostReadService _postReadService;
        public CreatePostReadCommonHandler(IPostReadService postReadService) => _postReadService = postReadService;

        public async Task<CreatePostReadCommonResponse> Handle(CreatePostReadCommonRequest request, CancellationToken cancellationToken)
        {


            try
            {
                await _postReadService.Create(new Dto_s.PostRead.CreatePostReadDto()
                {
                    isActiveRead = request.isActiveRead,
                    PostsId = request.PostsId,
                    ReadTime = request.ReadTime,
                });

                return new CreatePostReadCommonResponse()
                {
                    Success = true,
                    Message = "Post Reading successfully."
                };
            }
            catch (Exception ex)
            {
                return new CreatePostReadCommonResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}


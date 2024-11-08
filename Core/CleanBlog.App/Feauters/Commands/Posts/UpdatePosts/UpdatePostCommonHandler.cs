using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Posts.UpdatePosts
{
    public class UpdatePostCommonHandler : IRequestHandler<UpdatePostCommonRequest, UpdatePostsCommonResponse>
    {

        readonly private IPostsService _postsService;

        public UpdatePostCommonHandler(IPostsService postsService)
        {
            _postsService = postsService;
        }

        public async Task<UpdatePostsCommonResponse> Handle(UpdatePostCommonRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _postsService.Update(new Dto_s.Posts.UpdatePostDto()
                {
                    Id=request.Id,
                    Description=request.Description,
                    Content=request.Content,
                    Title=request.Title,    

                });

                return new UpdatePostsCommonResponse()
                {
                    Success = true,
                    Message = "Posts created successfully"
                };
            }
            catch (Exception ex)
            {
                return new UpdatePostsCommonResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}

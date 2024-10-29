using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Posts.DeletePosts
{
    public class DeletePostCommonHandler : IRequestHandler<DeletePostsCommonRequest, DeletePostCommonResponse>
    {
        readonly private IPostsService _postsService;
        public DeletePostCommonHandler(IPostsService postsService) => _postsService = postsService;

        public async Task<DeletePostCommonResponse> Handle(DeletePostsCommonRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _postsService.Delete(request.id);
                return new DeletePostCommonResponse()
                {
                    Success = true,
                    Message = "Posts deleted successfully"
                };
            }
            catch (Exception ex)
            {
                return new DeletePostCommonResponse()
                {
                    Success = true,
                    Message = ex.Message
                };
            }
        }
    }
}

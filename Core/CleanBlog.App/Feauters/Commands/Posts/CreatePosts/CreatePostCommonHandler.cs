using CleanBlog.App.Applications.Services;
using CleanBlog.App.Feauters.Commands.About.CreateAbout;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Posts.CreatePosts
{
    public class CreatePostCommonHandler : IRequestHandler<CreatePostsCommonRequest, CreatePostCommonResponse>
    {
        private readonly IPostsService _postsService;

        public CreatePostCommonHandler(IPostsService postsService)
        {
            _postsService = postsService;
        }

        public async Task<CreatePostCommonResponse> Handle(CreatePostsCommonRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _postsService.Create(new Dto_s.Posts.CreatePostDto()
                {
                    Content = request.Content,
                    Description = request.Description,
                    Title = request.Title,  
                });
                return new CreatePostCommonResponse
                {
                   
                    Success = true,
                    Message = "Post created successfully."
                };
            }
            catch (Exception ex)
            {
                // Hata loglama veya özel hata işleme
                return new CreatePostCommonResponse
                {
                    Success = false,
                    Message = ex.Message 
                };
            }
        }
    }
}

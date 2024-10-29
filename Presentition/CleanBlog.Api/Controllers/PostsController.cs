using CleanBlog.App.Feauters.Commands.Posts.CreatePosts;
using CleanBlog.App.Feauters.Commands.Posts.DeletePosts;
using CleanBlog.App.Feauters.Commands.Posts.UpdatePosts;
using CleanBlog.App.Feauters.Queries.Posts.GetPostsAll;
using CleanBlog.App.Feauters.Queries.Posts.GetPostsById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        readonly private IMediator _mediator;

        public PostsController(IMediator mediator)=> _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery]GetPostAllQueriesRequest getPostAllQueriesRequest)
        {
            GetPostAllQueriesResponse getPostAllQueriesResponse = await _mediator.Send(getPostAllQueriesRequest);

            return Ok(getPostAllQueriesResponse);   
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Index([FromRoute] GetPostByIdQueriesRequest getPostByIdQueriesRequest)
        {
            GetPostByIdQueriesResponse getPostByIdQueriesResponse = await _mediator.Send(getPostByIdQueriesRequest);

            return Ok(getPostByIdQueriesResponse);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreatePostsCommonRequest createPostsCommonRequest)
        {
            CreatePostCommonResponse createPostCommonResponse = await _mediator.Send(createPostsCommonRequest);

            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]

        public async Task<IActionResult> Update([FromBody] UpdatePostCommonRequest updatePostCommonRequest)
        {
            UpdatePostsCommonResponse updatePostsCommonResponse = await _mediator.Send(updatePostCommonRequest);

            return Ok(updatePostsCommonResponse);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute]DeletePostsCommonRequest deletePostsCommonRequest)
        {
            DeletePostCommonResponse deletePostCommonResponse = await _mediator.Send(deletePostsCommonRequest);

            return Ok(deletePostCommonResponse);
        }
    }
}

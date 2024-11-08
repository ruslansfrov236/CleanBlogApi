using CleanBlog.App.Feauters.Commands.Header.CreateHeader;
using CleanBlog.App.Feauters.Commands.Header.DeleteHeader;
using CleanBlog.App.Feauters.Commands.Header.UpdateHeader;
using CleanBlog.App.Feauters.Commands.PostRead.CreatePostRead;
using CleanBlog.App.Feauters.Commands.PostRead.DeletePostRead;
using CleanBlog.App.Feauters.Commands.PostRead.UpdatePostRead;
using CleanBlog.App.Feauters.Queries.Header.GetHeaderAll;
using CleanBlog.App.Feauters.Queries.Header.GetHeaderById;
using CleanBlog.App.Feauters.Queries.PostRead.GetPostReadAll;
using CleanBlog.App.Feauters.Queries.PostRead.GetPostReadById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostReadController : ControllerBase
    {
        readonly private IMediator _mediator;

        public PostReadController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] GetPostReadAllQueriesRequest  getPostReadAllQueriesRequest)
        {
            GetPostReadAllQueriesResponse getPostReadAllQueriesResponse = await _mediator.Send(getPostReadAllQueriesRequest);
            return Ok(getPostReadAllQueriesResponse);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Index([FromRoute] GetPostReadByIdQueriesRequest getPostReadByIdQueriesRequest)
        {
           GetPostReadByIdQueriesResponse postReadByIdQueriesResponse = await _mediator.Send(getPostReadByIdQueriesRequest);

            return Ok(postReadByIdQueriesResponse);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePostReadCommonRequest createPostReadCommonRequest)
        {
            CreatePostReadCommonResponse createPostReadCommonResponse = await _mediator.Send(createPostReadCommonRequest);

            return Ok(createPostReadCommonResponse);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatePostReadCommonRequest updatePostReadCommonRequest)
        {
            UpdatePostReadCommonResponse updatePostReadCommonResponse = await _mediator.Send(updatePostReadCommonRequest);

            return Ok(updatePostReadCommonResponse);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] DeletePostReadCommonRequest deletePostReadCommonRequest)
        {
            DeletePostReadCommonResponse deletePostReadCommonResponse = await _mediator.Send(deletePostReadCommonRequest);
            return Ok(deletePostReadCommonResponse);
        }
    }
}

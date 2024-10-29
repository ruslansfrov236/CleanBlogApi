using CleanBlog.App.Feauters.Commands.Message.CreateMessage;
using CleanBlog.App.Feauters.Queries.About.GetAboutAll;
using CleanBlog.App.Feauters.Queries.ContactDescription.GetContactDescription;
using CleanBlog.App.Feauters.Queries.Header.GetHeaderAll;
using CleanBlog.App.Feauters.Queries.Posts.GetPostsAll;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UiController : ControllerBase
    {
        readonly private IMediator _mediator;
        public UiController(IMediator mediator)=> _mediator = mediator;
        [HttpGet("about")]
        public async Task<IActionResult> Index([FromHeader]GetAboutAllQueriesRequest getAboutAllQueriesRequest)
        {
            GetAboutAllQueriesResponse getAboutAllQueriesResponse = await _mediator.Send(getAboutAllQueriesRequest);

            return Ok(getAboutAllQueriesResponse);
        }
        [HttpGet("header")]
        public async Task<IActionResult> Index([FromHeader]GetHeaderAllQueriesRequest getHeaderAllQueriesRequest)
        {
            GetHeaderAllQueriesResponse getHeaderAllQueriesResponse = await _mediator.Send(getHeaderAllQueriesRequest);

            return Ok(getHeaderAllQueriesResponse);
        }
        [HttpGet("contact-description")]
        public async Task<IActionResult> Index([FromHeader]GetContactDescriptionAllQueriuesRequest getContactDescriptionAllQueriuesRequest)
        {
            GetContactDescriptionAllQueriuesResponse getContactDescriptionAllQueriuesResponse = await _mediator.Send(getContactDescriptionAllQueriuesRequest);

            return Ok(getContactDescriptionAllQueriuesResponse);
        }
        [HttpGet("posts")]
        public async Task<IActionResult> Index([FromQuery] GetPostAllQueriesRequest getPostAllQueriesRequest)
        {
            GetPostAllQueriesResponse getPostAllQueriesResponse = await _mediator.Send(getPostAllQueriesRequest);
            return Ok(getPostAllQueriesResponse);
        }
        
            [HttpPost("message/created")]
        public async Task<IActionResult> Create([FromBody]CreateMessageCommonRequest createMessageCommonRequest)
        {
           CreateMessageCommonResponse createMessageCommonResponse = await _mediator.Send(createMessageCommonRequest); 

            return StatusCode((int)HttpStatusCode.Created);
        }

    }
}

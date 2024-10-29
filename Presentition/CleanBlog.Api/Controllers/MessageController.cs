using CleanBlog.App.Feauters.Queries.Message.GetMessageAll;
using CleanBlog.App.Feauters.Queries.Message.GetMessageById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        readonly private IMediator _mediator;
        public MessageController(IMediator mediator)
        {
            _mediator= mediator;    
        }
        [HttpGet]
        public async Task<IActionResult> Index([FromQuery]GetMessageAllQueriesRequest getMessageAllQueriesRequest)
        {
            GetMessageAllQueriesResponse getMessageAllQueriesResponse = await _mediator.Send(getMessageAllQueriesRequest);
            return Ok(getMessageAllQueriesResponse);    
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Index([FromRoute]GetMessageByIdQueriesRequest getMessageByIdQueriesRequest)
        {
            GetMessageByIdQueriesResponse getMessageByIdQueriesResponse = await _mediator.Send(getMessageByIdQueriesRequest);

            return Ok(getMessageByIdQueriesResponse);
        }
    }
}

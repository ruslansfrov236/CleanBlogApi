using CleanBlog.App.Feauters.Commands.Header.CreateHeader;
using CleanBlog.App.Feauters.Commands.Header.DeleteHeader;
using CleanBlog.App.Feauters.Commands.Header.UpdateHeader;
using CleanBlog.App.Feauters.Queries.Header.GetHeaderAll;
using CleanBlog.App.Feauters.Queries.Header.GetHeaderById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeaderController : ControllerBase
    {
        readonly private IMediator _mediator;

        public HeaderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] GetHeaderAllQueriesRequest getHeaderAllQueriesRequest)
        {
            GetHeaderAllQueriesResponse getHeaderAllQueriesResponse= await _mediator.Send(getHeaderAllQueriesRequest);
            return Ok(getHeaderAllQueriesResponse);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Index([FromRoute]GetHeaderByIdQueriuesRequest getHeaderByIdQueriuesRequest)
        {
            GetHeaderByIdQueriuesResponse getHeaderByIdQueriuesResponse = await _mediator.Send(getHeaderByIdQueriuesRequest);

            return Ok(getHeaderByIdQueriuesResponse);
        }
        [HttpPost]
        public async Task<IActionResult> Create( CreateHeaderCommonRequest createHeaderCommonRequest)
        {
            CreateHeaderCommonResponse createHeaderCommonResponse = await _mediator.Send(createHeaderCommonRequest);

            return Ok(createHeaderCommonResponse);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] UpdateHeaderCommonRequest  updateHeaderCommonRequest)
        {
            UpdateHeaderCommonResponse updateHeaderCommonResponse = await _mediator.Send(updateHeaderCommonRequest);

            return Ok(updateHeaderCommonResponse);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteHeaderCommonRequest deleteHeaderCommonRequest)
        {
            DeleteHeaderCommonResponse deleteHeaderCommonResponse = await _mediator.Send(deleteHeaderCommonRequest); 
            return Ok(deleteHeaderCommonResponse);
        }
    }
}

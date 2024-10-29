using CleanBlog.App.Feauters.Commands.About.CreateAbout;
using CleanBlog.App.Feauters.Commands.About.DeleteAbout;
using CleanBlog.App.Feauters.Commands.About.UpdateAbout;
using CleanBlog.App.Feauters.Queries.About.GetAboutAll;
using CleanBlog.App.Feauters.Queries.About.GetAboutById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        readonly private IMediator _mediator;

        public AboutController(IMediator mediator)=> _mediator= mediator;   
        
        [HttpGet]
        public async Task<IActionResult> Index([ FromHeader]GetAboutAllQueriesRequest getAboutAllQueries)
        {
            GetAboutAllQueriesResponse getAboutAllQueriesResponse = await _mediator.Send(getAboutAllQueries);
            return Ok(getAboutAllQueriesResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Index([FromRoute]GetAboutByIdQueriesRequest getAboutByIdQueriesRequest)
        {
            GetAboutByIdQueriesResponse getAboutByIdQueriesResponse = await _mediator.Send(getAboutByIdQueriesRequest);

            return Ok(getAboutByIdQueriesResponse); 
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAboutCommonRequest createAboutCommonRequest)
        {
            CreateAboutCommonResponse createAboutCommonResponse = await _mediator.Send(createAboutCommonRequest);

            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<ActionResult> Update([FromBody]UpdateAboutCommonRequest updateAboutCommonRequest)
        {
            UpdateAboutCommonResponse updateAboutCommonResponse = await _mediator.Send(updateAboutCommonRequest);

            return Ok(updateAboutCommonResponse);   
        }
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete([FromRoute] DeleteAboutCommonRequest deleteAboutCommonRequest)
        {
            DeleteAboutCommonResponse deleteAboutCommonResponse = await _mediator.Send(deleteAboutCommonRequest);

            return Ok(deleteAboutCommonResponse);   
        }
    }
}

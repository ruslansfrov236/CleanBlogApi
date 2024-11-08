using CleanBlog.App.Feauters.Commands.ContactDescription.CreateContactDescription;
using CleanBlog.App.Feauters.Commands.ContactDescription.DeleteContactDescription;
using CleanBlog.App.Feauters.Commands.ContactDescription.UpdateContactDescription;
using CleanBlog.App.Feauters.Queries.ContactDescription.GetContactDescription;
using CleanBlog.App.Feauters.Queries.ContactDescription.GetContactDescriptionById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDescriptionController : ControllerBase
    {
        readonly private IMediator _mediator;

        public ContactDescriptionController(IMediator mediator)=> _mediator=mediator;   
        
        [HttpGet]
        public async Task<IActionResult> Index([FromHeader]GetContactDescriptionAllQueriuesRequest getContactDescriptionAllQueriuesRequest)
        {
            GetContactDescriptionAllQueriuesResponse getContactDescriptionAllQueriuesResponse = await _mediator.Send(getContactDescriptionAllQueriuesRequest);

            return Ok(getContactDescriptionAllQueriuesResponse);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Index([FromRoute]GetContactDescriptionByIdQueriesRequest getContactDescriptionByIdQueriesRequest)
        {
            GetContactDescriptionByIdQueriesResponse getContactDescriptionByIdQueriesResponse = await _mediator.Send(getContactDescriptionByIdQueriesRequest);

            return Ok(getContactDescriptionByIdQueriesResponse);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateContactDescriptionCommonRequest createContactDescriptionCommonRequest)
        {
            CreateContactDescriptionCommonResponse createContactDescriptionCommonResponse = await _mediator.Send(createContactDescriptionCommonRequest);

            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]UpdateContactDescriptionCommondsRequest updateContactDescriptionCommondsRequest)
        {
            UpdateContactDescriptionCommandsResponse updateContactDescriptionCommandsResponse = await _mediator.Send(updateContactDescriptionCommondsRequest);

            return Ok(updateContactDescriptionCommandsResponse);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute]DeleteContactDescriptionCommandsRequest deleteContactDescriptionCommandsRequest)
        {
            DeleteContactDescriptionCommandsResponse deleteContactDescriptionCommandsResponse = await _mediator.Send(deleteContactDescriptionCommandsRequest);

            return Ok(deleteContactDescriptionCommandsResponse);
        }
    }
}

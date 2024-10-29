using CleanBlog.App.Applications.Services;
using CleanBlog.App.Feauters.Queries.ContactDescription.GetContactDescription;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.ContactDescription.GetContactDescriptionById
{
    public class GetContactDescriptionByIdQueriesHandler : IRequestHandler<GetContactDescriptionByIdQueriesRequest, GetContactDescriptionByIdQueriesResponse>
    {
        readonly private IContactsDescriptionService _contactsDescriptionService;
        public GetContactDescriptionByIdQueriesHandler(IContactsDescriptionService contactsDescriptionService)=> _contactsDescriptionService = contactsDescriptionService;
 
        public async Task<GetContactDescriptionByIdQueriesResponse> Handle(GetContactDescriptionByIdQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
             var contactDescription =    await _contactsDescriptionService.GetById(request.id);

                return new GetContactDescriptionByIdQueriesResponse()
                {
                    Success = true,
                    Message = string.Empty,
                    ContactDescription= contactDescription  
                };
            }
            catch (Exception ex)
            {
                return new GetContactDescriptionByIdQueriesResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}

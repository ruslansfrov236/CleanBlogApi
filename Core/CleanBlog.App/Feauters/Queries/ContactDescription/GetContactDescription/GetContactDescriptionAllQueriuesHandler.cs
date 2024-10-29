using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.ContactDescription.GetContactDescription
{
    public class GetContactDescriptionAllQueriuesHandler : IRequestHandler<GetContactDescriptionAllQueriuesRequest, GetContactDescriptionAllQueriuesResponse>
    {
        readonly private IContactsDescriptionService _contactsDescriptionService;

        public GetContactDescriptionAllQueriuesHandler(IContactsDescriptionService contactsDescriptionService) => _contactsDescriptionService = contactsDescriptionService;

        public async Task<GetContactDescriptionAllQueriuesResponse> Handle(GetContactDescriptionAllQueriuesRequest request, CancellationToken cancellationToken)
        {
            try
            {
               var contacts=  await _contactsDescriptionService.GetAll();

                return new GetContactDescriptionAllQueriuesResponse()
                {
                    Success=true,
                    Message=string.Empty ,
                    ContactDescription=contacts
                };
            }
            catch (Exception ex)
            {
                return new GetContactDescriptionAllQueriuesResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}

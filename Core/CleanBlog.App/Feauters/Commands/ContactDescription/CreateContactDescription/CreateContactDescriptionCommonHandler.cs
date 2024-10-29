using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.ContactDescription.CreateContactDescription
{
    public class CreateContactDescriptionCommonHandler : IRequestHandler<CreateContactDescriptionCommonRequest, CreateContactDescriptionCommonResponse>
    {
        readonly private IContactsDescriptionService _contactsDescriptionService;

        public CreateContactDescriptionCommonHandler(IContactsDescriptionService contactsDescriptionService) => _contactsDescriptionService = contactsDescriptionService;

        public async Task<CreateContactDescriptionCommonResponse> Handle(CreateContactDescriptionCommonRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _contactsDescriptionService.Create(request.CreateContactsDescriptionDto);
                return new CreateContactDescriptionCommonResponse()
                {
                    Success = true,
                    Message= "Contact Description created successfully"

                };

            }
            catch (Exception ex)
            {
                return new CreateContactDescriptionCommonResponse()
                {
                    Success = false,
                    Message = ex.Message

                };
            }
        }
    }
}

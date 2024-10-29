using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.ContactDescription.DeleteContactDescription
{
    public class DeleteContactDescriptionCommandsHandler : IRequestHandler<DeleteContactDescriptionCommandsRequest, DeleteContactDescriptionCommandsResponse>
    {
        readonly private IContactsDescriptionService _contactsDescriptionService;

        public DeleteContactDescriptionCommandsHandler(IContactsDescriptionService contactsDescriptionService) => _contactsDescriptionService = contactsDescriptionService;

        public async Task<DeleteContactDescriptionCommandsResponse> Handle(DeleteContactDescriptionCommandsRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _contactsDescriptionService.Delete(request.id);

                return new DeleteContactDescriptionCommandsResponse()
                {
                    Success= true,
                    Message="Contact Description deleted successfully"
                };
            }
            catch (Exception ex)
            {
                return new DeleteContactDescriptionCommandsResponse()
                {
                    Success= false,
                    Message= ex.Message 
                };
            }
        }
    }
}

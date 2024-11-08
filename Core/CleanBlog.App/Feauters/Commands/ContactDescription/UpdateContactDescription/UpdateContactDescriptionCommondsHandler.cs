using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.ContactDescription.UpdateContactDescription
{
    public class UpdateContactDescriptionCommondsHandler : IRequestHandler<UpdateContactDescriptionCommondsRequest, UpdateContactDescriptionCommandsResponse>
    {
        readonly private IContactsDescriptionService _contactsDescriptionService;

        public UpdateContactDescriptionCommondsHandler(IContactsDescriptionService contactsDescriptionService) => _contactsDescriptionService = contactsDescriptionService;

        public async Task<UpdateContactDescriptionCommandsResponse> Handle(UpdateContactDescriptionCommondsRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _contactsDescriptionService.Update(new Dto_s.ContactsDescription.UpdateContactsDescriptionDto() {
                Id=request.Id,
                Description=request.Description,    
                
                });
                return new UpdateContactDescriptionCommandsResponse()
                {
                    Success = true,
                    Message = "Contact Description updated successfully"
                };
            }
            catch (Exception ex)
            {
                return new UpdateContactDescriptionCommandsResponse()
                {
                    Success= false,
                    Message = ex.Message,


                };

            }
        }
    }
}

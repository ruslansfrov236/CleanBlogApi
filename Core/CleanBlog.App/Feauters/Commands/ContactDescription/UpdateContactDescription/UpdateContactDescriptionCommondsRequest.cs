using CleanBlog.App.Dto_s.ContactsDescription;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.ContactDescription.UpdateContactDescription
{
    public class UpdateContactDescriptionCommondsRequest:IRequest<UpdateContactDescriptionCommandsResponse>
    {

        public string Id { get; set; }
        public string? Description { get; set; }
    }
}

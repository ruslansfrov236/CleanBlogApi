using CleanBlog.App.Dto_s.ContactsDescription;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.ContactDescription.CreateContactDescription
{
    public class CreateContactDescriptionCommonRequest:IRequest<CreateContactDescriptionCommonResponse>
    {
        public CreateContactsDescriptionDto CreateContactsDescriptionDto { get; set; }
    }
}

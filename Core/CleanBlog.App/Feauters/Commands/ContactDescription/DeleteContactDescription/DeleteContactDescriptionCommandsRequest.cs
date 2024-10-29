using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.ContactDescription.DeleteContactDescription
{
    public class DeleteContactDescriptionCommandsRequest:IRequest<DeleteContactDescriptionCommandsResponse>
    {
        public string id { get; set; }  
    }
}

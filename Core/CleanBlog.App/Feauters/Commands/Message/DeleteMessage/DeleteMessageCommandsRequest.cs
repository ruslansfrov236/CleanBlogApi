using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Message.DeleteMessage
{
 public class DeleteMessageCommandsRequest:IRequest<DeleteMessageCommandResponse>

    {
        public string id { get; set; }  
    }
}

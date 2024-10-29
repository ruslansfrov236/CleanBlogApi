using CleanBlog.App.Dto_s.Message;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Message.CreateMessage
{
    public class CreateMessageCommonRequest:IRequest<CreateMessageCommonResponse>
    {
        public CreateMessageDto CreateMessageDto { get; set; }
    }
}

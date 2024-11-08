using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Message.CreateMessage
{
    public class CreateMessageCommonHandler : IRequestHandler<CreateMessageCommonRequest, CreateMessageCommonResponse>
    {
        readonly private IMessageService _messageService;

        public CreateMessageCommonHandler(IMessageService messageService)=> _messageService = messageService;   
        
        public async Task<CreateMessageCommonResponse> Handle(CreateMessageCommonRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _messageService.Create( new Dto_s.Message.CreateMessageDto(){
                    Email = request.Email,
                    Name = request.Name,
                    Messages= request.Messages,
                    Phone= request.Phone,   
                });
                return new CreateMessageCommonResponse()
                {
                    Success = true,
                    Message = "Message created successfully"
                };
            }
            catch (Exception ex)
            {
                return new CreateMessageCommonResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }
        }
    }
}


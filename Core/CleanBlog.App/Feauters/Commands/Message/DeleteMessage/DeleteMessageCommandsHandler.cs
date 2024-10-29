using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Message.DeleteMessage
{
    public class DeleteMessageCommandsHandler : IRequestHandler<DeleteMessageCommandsRequest, DeleteMessageCommandResponse>
    {
        readonly private IMessageService _messageService;

        public DeleteMessageCommandsHandler(IMessageService messageService) => _messageService = messageService;


        public async Task<DeleteMessageCommandResponse> Handle(DeleteMessageCommandsRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _messageService.Delete(request.id);
                return new DeleteMessageCommandResponse()
                {
                    Success = true,
                    Message = "Message deleted succesfully"
                };
            }
            catch (Exception ex)
            {


                return new DeleteMessageCommandResponse()
                {
                    Success = false, 
                    Message = ex.Message
                };

            }
            }
    }
}

using CleanBlog.App.Applications.Services;
using CleanBlog.App.Feauters.Queries.Message.GetMessageAll;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Message.GetMessageById
{
    public class GetMessageByIdQueriesHandler : IRequestHandler<GetMessageByIdQueriesRequest, GetMessageByIdQueriesResponse>
    {
        readonly private IMessageService _messageService;

        public GetMessageByIdQueriesHandler(IMessageService messageService) => _messageService = messageService;    
       
        async Task<GetMessageByIdQueriesResponse> IRequestHandler<GetMessageByIdQueriesRequest, GetMessageByIdQueriesResponse>.Handle(GetMessageByIdQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
              var messages=  await _messageService.GetById(request.id);

                return new GetMessageByIdQueriesResponse()
                {
                    Success = true,
                    Message = string.Empty,
                    Messages=messages
                };
            }
            catch (Exception ex)
            {
                return new GetMessageByIdQueriesResponse()
                {
                    Success = false,
                    Message = ex.Message,
                };

            }
        }
    }
}

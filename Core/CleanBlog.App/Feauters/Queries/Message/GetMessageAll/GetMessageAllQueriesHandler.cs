using CleanBlog.App.Applications.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Message.GetMessageAll
{
    public class GetMessageAllQueriesHandler : IRequestHandler<GetMessageAllQueriesRequest, GetMessageAllQueriesResponse>
    {
        readonly private  IMessageService _messageService;

        public GetMessageAllQueriesHandler(IMessageService messageService) => _messageService=messageService;

        public async Task<GetMessageAllQueriesResponse> Handle(GetMessageAllQueriesRequest request, CancellationToken cancellationToken)
        {
            try
            {
              var messages=   await  _messageService.GetAll(request.Size, request.Page);

                return new GetMessageAllQueriesResponse()
                {
                    Success = true,
                    Message = string.Empty,
                    Messages = messages
                };
            }
            catch (Exception ex)
            {
                return new GetMessageAllQueriesResponse()
                {
                    Success = false,
                    Message = ex.Message,
                };

            }
        }
    }
}

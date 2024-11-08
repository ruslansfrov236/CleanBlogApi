using CleanBlog.App.Applications.Services;
using CleanBlog.App.Feauters.Commands.About.UpdateAbout;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.PostRead.UpdatePostRead
{
    public class UpdatePostReadCommonHandler : IRequestHandler<UpdatePostReadCommonRequest, UpdatePostReadCommonResponse>
    {
        readonly private IPostReadService _postReadService;

        public UpdatePostReadCommonHandler(IPostReadService postReadService)
        {
            _postReadService = postReadService;
        }
        async Task<UpdatePostReadCommonResponse> IRequestHandler<UpdatePostReadCommonRequest, UpdatePostReadCommonResponse>.Handle(UpdatePostReadCommonRequest request, CancellationToken cancellationToken)
        {

            try
            {
                await _postReadService.Update(new Dto_s.PostRead.UpdatePostReadDto()
                {
                    id= request.Id,
                    isActiveRead= request.isActiveRead,
                    PostsId= request.PostsId,
                    ReadTime= request.ReadTime, 

                });
                return new UpdatePostReadCommonResponse()
                {
                    Success = true,
                    Message = "About updated successfully"
                };
            }
            catch (Exception ex)
            {

                return new UpdatePostReadCommonResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }


        }
    }
}

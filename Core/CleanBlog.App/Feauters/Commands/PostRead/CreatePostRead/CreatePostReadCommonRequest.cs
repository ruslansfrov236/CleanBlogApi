using CleanBlog.App.Dto_s.PostRead;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.PostRead.CreatePostRead
{
    public class CreatePostReadCommonRequest:IRequest<CreatePostReadCommonResponse>
    {
        public bool isActiveRead { get; set; }

        public DateTime ReadTime { get; set; }
        public Guid PostsId { get; set; }
    }
}

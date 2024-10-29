using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Posts.DeletePosts
{
    public class DeletePostsCommonRequest:IRequest<DeletePostCommonResponse>
    {
        public string id { get; set; }  
    }
}

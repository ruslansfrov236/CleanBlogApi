using CleanBlog.App.Dto_s.Posts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Posts.UpdatePosts
{
    public class UpdatePostCommonRequest:IRequest<UpdatePostsCommonResponse>
    {
        public string Id { get; set; }  
        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }
    }
}

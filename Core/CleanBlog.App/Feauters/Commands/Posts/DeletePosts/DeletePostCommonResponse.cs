using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Posts.DeletePosts
{
    public class DeletePostCommonResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}

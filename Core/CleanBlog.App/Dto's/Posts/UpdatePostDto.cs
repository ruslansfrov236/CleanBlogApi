using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Dto_s.Posts
{
    public class UpdatePostDto
    {
        public string Id { get; set; } 
        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

       
    }
}

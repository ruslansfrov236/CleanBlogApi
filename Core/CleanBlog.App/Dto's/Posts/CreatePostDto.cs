using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Dto_s.Posts
{
    public class CreatePostDto
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool isActiveRead { get; set; }

        public DateTime ReadTime { get; set; }
    }
}

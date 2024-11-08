using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Dto_s.PostRead
{
    public class UpdatePostReadDto
    { 
        public string id {  get; set; } 
        public bool isActiveRead { get; set; }
        public Guid PostsId { get; set; }
        public DateTime ReadTime { get; set; }
    }
}

using CleanBlog.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Domain.Entities
{
    public class PostRead:BaseEntity
    {
        public bool isActiveRead { get; set; }

        public DateTime ReadTime { get; set; }

        public Posts Posts { get; set; }

        public Guid PostsId { get; set; }  
    }
}

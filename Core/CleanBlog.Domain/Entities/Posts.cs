﻿using CleanBlog.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Domain.Entities
{
    public class Posts:BaseEntity
    {
        public string Title { get; set; }   

        public string Description { get; set; }

        public string Content { get; set; } 

        public List<PostRead> PostReads { get; set; }

       
    }
}

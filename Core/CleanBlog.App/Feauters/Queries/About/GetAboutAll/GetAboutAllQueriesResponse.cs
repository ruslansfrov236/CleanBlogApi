﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.About.GetAboutAll
{
    public class GetAboutAllQueriesResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } 
        public object About { get; set; }
    }
}

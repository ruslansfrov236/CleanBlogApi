using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Dto_s.Header
{
    public class CreateHeaderDto
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? FileName { get; set; }

        public int? PageNumber { get; set; }
        [NotMapped]
        public IFormFile formFile { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Dto_s.HeaderImages
{
    public class CreateHaderImagesDto
    {
        

        public Guid HeaderId { get; set; }

        public string Image { get; set; }
        [NotMapped]
        public IFormFile formFile { get; set; }

    }
}

using CleanBlog.App.Dto_s.Header;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Header.UpdateHeader
{
   public class UpdateHeaderCommonRequest:IRequest<UpdateHeaderCommonResponse>
    {
        public string? Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? FileName { get; set; }

        public int? PageNumber { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }
    }
}

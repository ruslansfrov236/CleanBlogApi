using CleanBlog.App.Dto_s.About;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.About.UpdateAbout
{
    public class UpdateAboutCommonRequest:IRequest<UpdateAboutCommonResponse>
    {
        public string Id{ get; set; }
        public string Description{ get; set; }
    }
}

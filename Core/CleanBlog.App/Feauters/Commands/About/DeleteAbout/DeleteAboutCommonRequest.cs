using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.About.DeleteAbout
{
    public class DeleteAboutCommonRequest:IRequest<DeleteAboutCommonResponse>
    {
        public string id { get; set; }  
    }
}

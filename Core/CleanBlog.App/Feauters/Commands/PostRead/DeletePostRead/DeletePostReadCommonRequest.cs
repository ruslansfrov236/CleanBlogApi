using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.PostRead.DeletePostRead
{
    public class DeletePostReadCommonRequest:IRequest<DeletePostReadCommonResponse>
    {
        public string id { get; set; }  
    }
}

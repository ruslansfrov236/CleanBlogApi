using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Header.DeleteHeader
{
    public class DeleteHeaderCommonRequest:IRequest<DeleteHeaderCommonResponse>
    {
        public string id { get; set; }  
    }
}

using CleanBlog.App.Dto_s.Header;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Header.UpdateHeader
{
   public class UpdateHeaderCommonRequest:IRequest<UpdateHeaderCommonResponse>
    {
        public UpdateHeaderDto UpdateHeaderDto { get; set; }
    }
}

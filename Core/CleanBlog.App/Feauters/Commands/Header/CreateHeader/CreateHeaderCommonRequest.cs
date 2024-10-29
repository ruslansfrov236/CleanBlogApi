using CleanBlog.App.Dto_s.Header;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Commands.Header.CreateHeader
{
    public class CreateHeaderCommonRequest:IRequest<CreateHeaderCommonResponse>
    {
        public CreateHeaderDto CreateHeaderDto { get; set; }
    }
}

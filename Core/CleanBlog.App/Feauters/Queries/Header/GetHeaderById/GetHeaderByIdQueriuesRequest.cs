using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.Header.GetHeaderById
{
    public class GetHeaderByIdQueriuesRequest:IRequest<GetHeaderByIdQueriuesResponse>
    {
        public string id { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.ContactDescription.GetContactDescriptionById
{
    public class GetContactDescriptionByIdQueriesRequest:IRequest<GetContactDescriptionByIdQueriesResponse>
    {
        public string id { get; set; }  
    }
}

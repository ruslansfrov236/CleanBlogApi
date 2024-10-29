using MediatR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Feauters.Queries.About.GetAboutById
{
    public class GetAboutByIdQueriesRequest:IRequest<GetAboutByIdQueriesResponse>
    {
        public string id { get; set; }  
    }
}

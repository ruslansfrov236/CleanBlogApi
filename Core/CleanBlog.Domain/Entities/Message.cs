using CleanBlog.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Domain.Entities
{
    public class Message:BaseEntity
    {
        public string Name { get; set; }    

        public string? Email { get; set; }

        public string? Phone {  get; set; }  

        public string Messages {  get; set; }    
    }

}

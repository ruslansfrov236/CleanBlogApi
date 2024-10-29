using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Dto_s.Message
{
    public class UpdateMessageDto
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string Messages { get; set; }
    }
}

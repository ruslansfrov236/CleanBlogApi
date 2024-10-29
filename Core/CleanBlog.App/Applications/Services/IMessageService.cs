using CleanBlog.App.Dto_s.Message;
using CleanBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Applications.Services
{
    public interface IMessageService
    {
        Task<List<Message>> GetAll( int page , int size );
        Task<Message> GetById(string id);
        Task<bool> Create(CreateMessageDto model);
       
        Task<bool> Delete(string id );
    }
}

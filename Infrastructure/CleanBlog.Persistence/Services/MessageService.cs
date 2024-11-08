using CleanBlog.App.Applications.Services;
using CleanBlog.App.Dto_s.Message;
using CleanBlog.App.Repository;
using CleanBlog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanBlog.Persistence.Services
{
    public class MessageService : IMessageService
    {
        readonly private IMessageWriteRepository _messageWriteRepository;
        readonly private IMessageReadRepository _messageReadRepository;

        public MessageService(IMessageReadRepository messageReadRepository , IMessageWriteRepository messageWriteRepository)
        {
            _messageReadRepository = messageReadRepository;
            _messageWriteRepository = messageWriteRepository;   
        }

        public async Task<bool> Create(CreateMessageDto model)
        {
            Message message = new Message() { 
             Name= model.Name,
             Email= model.Email,
             Phone= model.Phone,
             Messages= model.Messages,
            };

            await _messageWriteRepository.AddAsync(message);
            await _messageWriteRepository.SaveAsync();  
            return true;

        }

        public async Task<bool> Delete(string id)
        {
           var message = await _messageReadRepository.GetByIdAsync(id);
            _messageWriteRepository.Remove(message);
            await _messageWriteRepository.SaveAsync();
            return true;
        }

        public async Task<List<Message>> GetAll(int page, int size)
        {
            List<Message> messages = await _messageReadRepository.GetAll().ToListAsync();

            return messages;
        }

        public async Task<Message> GetById(string id)
       => await _messageReadRepository.GetByIdAsync(id);

    }
}

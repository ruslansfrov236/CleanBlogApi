using CleanBlog.App.Applications.Services;
using CleanBlog.App.Dto_s.PostRead;
using CleanBlog.App.Repository;
using CleanBlog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Persistence.Services
{
    public class PostReadService : IPostReadService
    {
        readonly private IPostReadReadRepository  _postReadReadRepository;
        readonly private IPostReadWriteRepository _postReadWriteRepository;

        public PostReadService(IPostReadReadRepository  postReadReadRepository , IPostReadWriteRepository postReadWriteRepository)
        {
            _postReadReadRepository = postReadReadRepository;
            _postReadWriteRepository= postReadWriteRepository;  
        }
        public async Task<bool> Create(CreatePostReadDto model)
        {
            PostRead postRead = new PostRead()
            {
                isActiveRead=model.isActiveRead,
                ReadTime = model.ReadTime,
                PostsId = model.PostsId
            };

          await  _postReadWriteRepository.AddAsync(postRead);
         await _postReadWriteRepository.SaveAsync();
            return true;
           
        }

        public async Task<bool> Delete(string id)
        {
            var postRead = await _postReadReadRepository.GetByIdAsync(id);
            if (postRead == null) throw new Exception("not found");
            _postReadWriteRepository.Remove(postRead);
            await _postReadWriteRepository.SaveAsync();

            return true;
        }

        public async Task<List<PostRead>> GetAll()
        {
            List<PostRead> posts = await _postReadReadRepository.GetAll().Include(a=>a.Posts).ToListAsync();

            return posts;
        }

        public async Task<bool> Update(UpdatePostReadDto model)
        {
            PostRead postRead = new PostRead()
            {
                Id = Guid.Parse(model.id),
                isActiveRead = model.isActiveRead,
                ReadTime = model.ReadTime,
                PostsId=model.PostsId
            };

             _postReadWriteRepository.Update(postRead);
            await _postReadWriteRepository.SaveAsync();
            return true;
        }
    }
}

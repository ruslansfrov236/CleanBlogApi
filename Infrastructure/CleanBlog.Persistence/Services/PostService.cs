using CleanBlog.App.Applications.Services;
using CleanBlog.App.Dto_s.Posts;
using CleanBlog.App.Repository;
using CleanBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Persistence.Services
{
    public class PostService : IPostsService
    {
        readonly private IPostReadRepository _postReadRepository;
        readonly private IPostWriteRepository _postWriteRepository;

        public PostService(IPostReadRepository postReadRepository, IPostWriteRepository postWriteRepository)
        {
            _postReadRepository= postReadRepository;    
            _postWriteRepository= postWriteRepository;
        }
        public async Task<bool> Create(CreatePostDto model)
        {
            Posts posts = new Posts() { 
            
            Title = model.Title,
            Content = model.Content,
            Description= model.Description,
            isActiveRead=model.isActiveRead,
            ReadTime=model.ReadTime,
            
            };
            await _postWriteRepository.AddAsync(posts);
            await _postWriteRepository.SaveAsync();
            return true;

        }

        public async Task<bool> Delete(string id)
        {
            var post = await _postReadRepository.GetByIdAsync(id);

            if (post != null) throw new Exception("not found ");

             _postWriteRepository.Remove(post);
            await _postWriteRepository.SaveAsync();
            return true;
        }

        public async Task<List<Posts>> GetAll(int page, int size)
        {
            List<Posts> posts =  _postReadRepository.GetAll().Take(size).Skip(page*size).ToList();

            return posts;
        }

        public async Task<Posts> GetById(string id)
        =>await _postReadRepository.GetByIdAsync(id);

        public async Task<bool> Update(UpdatePostDto model)
        {
            Posts posts = new Posts();
            posts.Title = model.Title;
            posts.Content = model.Content;
            posts.Description = model.Description;
            

           _postWriteRepository.Update(posts);
            await _postWriteRepository.SaveAsync();
            return true;
        }
    }
}

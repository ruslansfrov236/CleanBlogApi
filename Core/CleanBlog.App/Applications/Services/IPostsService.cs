using CleanBlog.App.Dto_s.Posts;
using CleanBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Applications.Services
{
    public interface IPostsService
    {
        Task<List<Posts>> GetAll(int page, int size ); 
        Task<Posts> GetById(string id);
        Task<bool> Create(CreatePostDto model);
        Task<bool> Update(UpdatePostDto model);
        Task<bool> Delete(string id);
    }
}

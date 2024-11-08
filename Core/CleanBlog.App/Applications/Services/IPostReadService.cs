using CleanBlog.App.Dto_s.PostRead;
using CleanBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Applications.Services
{
    public interface IPostReadService
    {
        Task<List<PostRead>> GetAll();
        Task<bool> Create(CreatePostReadDto model);
        Task<bool> Update(UpdatePostReadDto model);
        Task<bool> Delete(string id);
    }
}

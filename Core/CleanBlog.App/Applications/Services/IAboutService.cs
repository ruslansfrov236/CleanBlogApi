using CleanBlog.App.Dto_s.About;
using CleanBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Applications.Services
{
    public interface IAboutService
    {
        Task<List<About>> GetAll();
        Task<About> GetById(string id );
        Task<bool> Create(CreateAboutDto model);
        Task<bool> Update(UpdateAboutDto model);
        Task<bool> Delete(string id );
    }
}

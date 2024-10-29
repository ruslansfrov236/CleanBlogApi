using CleanBlog.App.Dto_s.Header;
using CleanBlog.App.Dto_s.Message;
using CleanBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Applications.Services
{
    public interface IHeaderService
    {
        Task<List<Header>> GetAll();
        Task<Header> GetById(string id);
        Task<bool> Create(CreateHeaderDto model );
        Task<bool> Update(UpdateHeaderDto model);
        Task<bool> Delete(string id );
    }
}

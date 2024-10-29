using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Applications
{
    public interface IStorageService
    {
        Task<string> UploadAsync(IFormFile file);
        bool IsImage(IFormFile file);
        bool CheckSize(IFormFile file, int maxSize);
        void Delete(string path);
    }
}

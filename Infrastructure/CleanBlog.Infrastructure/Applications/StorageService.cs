using CleanBlog.App.Applications;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CleanBlog.Infrastructure.Applications
{
    public class StorageService : IStorageService
    {
        private readonly IWebHostEnvironment _env;

        public StorageService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public bool CheckSize(IFormFile file, int maxSize)
        => (file.Length / 1024) > maxSize;

        public void Delete(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }

        public bool IsImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return false;

            if (!file.ContentType.StartsWith("image/"))
                return false;

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            var fileExtension = Path.GetExtension(file.FileName).ToLowerInvariant();
            return allowedExtensions.Contains(fileExtension);
        }

        public async Task<string> UploadAsync(IFormFile file)
        {
            var filename = $"{Guid.NewGuid()}_{Path.GetFileNameWithoutExtension(file.FileName)}.png";
            var tempPath = Path.Combine(_env.WebRootPath, "assets/image/temp_" + file.FileName);
            var pngPath = Path.Combine(_env.WebRootPath, "assets/image", filename);

           
            using (var fileStream = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
            {
                await file.CopyToAsync(fileStream);
            }

           
            using (var image = await Image.LoadAsync(tempPath))
            {
                await image.SaveAsync(pngPath, new PngEncoder());
            }

           
            File.Delete(tempPath);

            return filename;
        }
    }
}

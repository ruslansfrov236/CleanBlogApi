using CleanBlog.App.Applications;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;

namespace CleanBlog.Infrastructure.Applications
{
    public class StorageService : IStorageService
    {
        public bool CheckSize(IFormFile file, int maxSize)
        {
            if (file.Length / 1024 < maxSize)
            {


                return false;
            }
            return true;
        }

        public void Delete(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }

        public bool IsImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {


                return false;

            }


            if (!file.ContentType.StartsWith("image/"))
            {

                return false;
            }


            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
            var fileExtension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (!allowedExtensions.Contains(fileExtension))
            {

                return false;
            }

            return true;
        }

        public async Task<string> UploadAsync(IFormFile file)
        {
            var filename = $"{Guid.NewGuid()}_{file.FileName}";

            var path = Path.Combine(Directory.GetCurrentDirectory(), "../../wwwroot/assets/image/", filename);
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "../../wwwroot/assets/image/", filename);
            var pngPath = Path.ChangeExtension(imagePath, "png");
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                await file.CopyToAsync(fileStream);
            }
            using (var image = Image.Load(imagePath))
            {
                image.Save(pngPath, new PngEncoder());
            }


            File.Delete(imagePath);

            return Path.GetFileName(pngPath);
        }
    }
}

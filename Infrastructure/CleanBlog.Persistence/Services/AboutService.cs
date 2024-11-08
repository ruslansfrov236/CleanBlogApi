using CleanBlog.App.Applications.Services;
using CleanBlog.App.Dto_s.About;
using CleanBlog.App.Repository;
using CleanBlog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanBlog.Persistence.Services
{
    public class AboutService : IAboutService
    {
        readonly private IAboutReadRepository _aboutReadRepository;
        readonly private IAboutWriteRepository _aboutWriteRepository;

        public AboutService(IAboutReadRepository aboutReadRepository, IAboutWriteRepository aboutWriteRepository)
        {
            _aboutReadRepository = aboutReadRepository;
            _aboutWriteRepository = aboutWriteRepository;
        }
        public async Task<bool> Create(CreateAboutDto model)
        {
            About about = new About()
            {
                Description = model.Description,
            };

            await _aboutWriteRepository.AddAsync(about);
            await _aboutWriteRepository.SaveAsync();

            return true;
        }

        public async Task<bool> Delete(string id)
        {
            var about = await _aboutReadRepository.GetByIdAsync(id);
            if (about == null) throw new Exception("not found");

                  _aboutWriteRepository.Remove(about);
            await _aboutWriteRepository.SaveAsync();
            return true;
        }

        public async Task<List<About>> GetAll()
        {
            List<About> abouts = await _aboutReadRepository.GetAll().ToListAsync();

            return abouts;
        }

        public async Task<About> GetById(string id)
        => await _aboutReadRepository.GetByIdAsync(id);

        public async Task<bool> Update(UpdateAboutDto model)
        {
            About about = new About();
            about.Id =Guid.Parse(model.Id);
            about.Description=model.Description;

           _aboutWriteRepository.Update(about);
            await _aboutWriteRepository.SaveAsync();

            return true;    
        }
    }
}

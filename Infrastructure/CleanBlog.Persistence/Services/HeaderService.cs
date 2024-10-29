using CleanBlog.App.Applications;
using CleanBlog.App.Applications.Services;
using CleanBlog.App.Dto_s.Header;
using CleanBlog.App.Dto_s.Message;
using CleanBlog.App.Repository;
using CleanBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Persistence.Services
{
    public class HeaderService : IHeaderService
    {
        readonly private IHeaderReadRepository _headerReadRepository;
        readonly private IHeaderWriteRepository _headerWriteRepository;
        readonly private IStorageService _storageService;
        public HeaderService(IHeaderReadRepository headerReadRepository, IHeaderWriteRepository headerWriteRepository, IStorageService storageService)
        {
            _headerReadRepository = headerReadRepository;
            _headerWriteRepository = headerWriteRepository;
            _storageService = storageService;
        }
        public async Task<bool> Create(CreateHeaderDto model)
        {
            var image = _storageService.IsImage(model.File);
            var imageSize = _storageService.CheckSize(model.File, 250);
            if (!image && !imageSize)
            {
                throw new Exception("not found file type image");
            }

            var file = await _storageService.UploadAsync(model.File);
            Header header = new Header()
            {
                Description = model.Description,
                Title = model.Title,
                PageNumber = model.PageNumber,
                FileName = file
            };



            await _headerWriteRepository.AddAsync(header);
            await _headerWriteRepository.SaveAsync();

            return true;

        }

        public async Task<bool> Delete(string id)
        {
            var header = await _headerReadRepository.GetByIdAsync(id);
            _storageService.Delete(header.FileName);
            _headerWriteRepository.Remove(header);
            await _headerWriteRepository.SaveAsync();

            return true;
        }

        public async Task<List<Header>> GetAll()
        {
            List<Header> headers =  _headerReadRepository.GetAll().ToList();

            return headers;
        }

        public async Task<Header> GetById(string id)
         => await _headerReadRepository.GetByIdAsync(id);

        public async Task<bool> Update(UpdateHeaderDto model)
        {
            if (model.File != null)
            {
                var image = _storageService.IsImage(model.File);
                var imageSize = _storageService.CheckSize(model.File, 250);
                if (!image && !imageSize)
                {
                    throw new Exception("not found file type image");
                }

                var file = await _storageService.UploadAsync(model.File);
                Header header = new Header()
                {
                    Description = model.Description,
                    Title = model.Title,
                    PageNumber = model.PageNumber,
                    FileName = file
                };
                _headerWriteRepository.Update(header);
            }
            else
            {
                Header header = new Header()
                {
                    Description = model.Description,
                    Title = model.Title,
                    PageNumber = model.PageNumber,
                   
                };
                _headerWriteRepository.Update(header);
            }
            await _headerWriteRepository.SaveAsync();
            return true;
        }
    }
}
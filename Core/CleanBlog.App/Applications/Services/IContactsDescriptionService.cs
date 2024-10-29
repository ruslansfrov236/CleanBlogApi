using CleanBlog.App.Dto_s.ContactsDescription;
using CleanBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Applications.Services
{
    public interface IContactsDescriptionService
    {
        Task<List<ContactsDescription>> GetAll();
        Task<ContactsDescription> GetById(string id);
        Task<bool> Create(CreateContactsDescriptionDto model );
        Task<bool> Update(UpdateContactsDescriptionDto model);
        Task<bool> Delete(string id );
    }
}

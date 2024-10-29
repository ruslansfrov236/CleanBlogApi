using CleanBlog.App.Repository;
using CleanBlog.Domain.Entities;
using CleanBlog.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Persistence.Repository
{
    public class ContactsDescriptionWriteRepository : WriteRepository<ContactsDescription>, IContactDescriptionWriteRepository
    {
        public ContactsDescriptionWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}

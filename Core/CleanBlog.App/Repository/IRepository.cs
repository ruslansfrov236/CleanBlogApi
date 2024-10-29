using CleanBlog.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;


namespace CleanBlog.App.Repository
{
    public  interface IRepository< T> where T : BaseEntity
    {
      DbSet<T> Table { get; }     
    }

   
}

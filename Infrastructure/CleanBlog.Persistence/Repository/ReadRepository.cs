using CleanBlog.App.Repository;
using CleanBlog.Domain.Entities.Common;
using CleanBlog.Persistence.Context;
using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

namespace CleanBlog.Persistence.Repository
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {

        readonly private AppDbContext _context;

        public ReadRepository(AppDbContext context)
        {
            _context= context;  
        }

        public DbSet<T> Table => _context.Set<T>(); 

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public  Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query.FirstOrDefaultAsync(a=>a.Id==Guid.Parse(id));
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query.Where(method);
        }
    }
}

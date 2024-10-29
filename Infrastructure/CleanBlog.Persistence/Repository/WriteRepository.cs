using CleanBlog.App.Repository;
using CleanBlog.Domain.Entities.Common;
using CleanBlog.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace CleanBlog.Persistence.Repository
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity 
   
    {

        readonly private AppDbContext _context;

        public WriteRepository(AppDbContext context)
        {
            _context= context;
        }

        public DbSet<T> Table => _context.Set<T>();


        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entity = await _context.AddAsync(model);

            return entity.State==EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> data)
        {
           await _context.AddRangeAsync(data);

            return true;
        }

        public  bool Remove(T model)
        {
            EntityEntry<T> entityEntry= _context.Remove(model); 
            return entityEntry.State==EntityState.Deleted;  

            
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T? model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));

            return Remove(model);
        }

        public  bool RemoveRange(List<T> data)
        {
             _context.RemoveRange(data);
            return true;
        }

        public Task<int> SaveAsync()
       => _context.SaveChangesAsync();

        public bool Update(T model)
        {
            EntityEntry entityEntry= _context.Update(model);    

            return entityEntry.State== EntityState.Modified;    
        }
    }
}

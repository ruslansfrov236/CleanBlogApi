using Microsoft.EntityFrameworkCore;
using CleanBlog.Domain.Entities;
using CleanBlog.Domain.Entities.Common;

namespace CleanBlog.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }


        public DbSet<About> Abouts { get; set; }    

        public DbSet<Header> Headers { get; set; }

        public DbSet<Message> Message { get; set; } 

        public DbSet<Posts> Posts { get; set; }

        public DbSet<ContactsDescription> Contacts { get; set; }

        public DbSet<PostRead> PostRead { get; set; }   

       

        

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            TimeZoneInfo azerbaijanTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time");

            var datas = ChangeTracker
                .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, azerbaijanTimeZone);
                        break;
                    case EntityState.Modified:
                        data.Entity.UpdatedDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, azerbaijanTimeZone);
                        break;
                    default:
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}

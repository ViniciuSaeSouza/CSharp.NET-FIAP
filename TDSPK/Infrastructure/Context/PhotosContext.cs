using Microsoft.EntityFrameworkCore;
using TDSPK.Infrastructure.Mappings;
using TDSPK.Infrastructure.Persistence;

namespace TDSPK.Infrastructure.Context
{
    public class PhotosContext(DbContextOptions<PhotosContext> options) : DbContext(options)
    {
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PhotoMapping());
        }
    }
}

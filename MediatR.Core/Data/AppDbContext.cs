using MediatR.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatR.Core.Data
{
      public class AppDbContext : DbContext
      {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
                  :base(options) 
        {
            
        }
            
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                  base.OnModelCreating(modelBuilder);
            }

            public DbSet<User> Users { get; set; }
    }
}

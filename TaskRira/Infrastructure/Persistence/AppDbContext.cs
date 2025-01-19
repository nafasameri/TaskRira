using Microsoft.EntityFrameworkCore;
using TaskRira.Domain.Entities;

namespace TaskRira.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}

using bizzlandTask.Models;
using Microsoft.EntityFrameworkCore;

namespace bizzlandTask.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}

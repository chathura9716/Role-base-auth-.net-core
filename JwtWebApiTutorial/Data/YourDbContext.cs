using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JwtWebApiTutorial.Data
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}

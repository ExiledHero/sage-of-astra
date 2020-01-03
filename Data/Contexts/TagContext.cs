using Microsoft.EntityFrameworkCore;
using SageOfAstra.Data;

namespace SageOfAstra.Data
{
    class TagContext : DbContext
    {
        public DbSet<TagValue> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Tags.sqlite;");
        }
    }
}

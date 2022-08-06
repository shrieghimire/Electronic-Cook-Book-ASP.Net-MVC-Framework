using Microsoft.EntityFrameworkCore;

namespace ECB.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        public DbSet<Food> Foods { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace DST.Infrastructure.SqlServer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
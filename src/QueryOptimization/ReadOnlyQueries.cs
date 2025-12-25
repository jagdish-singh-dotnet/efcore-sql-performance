using Microsoft.EntityFrameworkCore;

namespace QueryOptimization
{
    public class ReadOnlyQueries
    {
        public void WithoutAsNoTracking(AppDbContext context)
        {
            // EF Core tracks all entities by default
            // This increases memory usage for read-only operations
            var users = context.Users.ToList();
        }

        public void WithAsNoTracking(AppDbContext context)
        {
            // AsNoTracking improves performance for read-only queries
            var users = context.Users
                               .AsNoTracking()
                               .ToList();
        }
    }
}

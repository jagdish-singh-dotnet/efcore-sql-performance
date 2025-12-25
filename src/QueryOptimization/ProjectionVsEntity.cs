using Microsoft.EntityFrameworkCore;

namespace QueryOptimization
{
    public class ProjectionVsEntity
    {
        public void FetchingFullEntity(AppDbContext context)
        {
            // Fetching entire entity when only few fields are needed
            var users = context.Users.ToList();
        }

        public void FetchingOnlyRequiredFields(AppDbContext context)
        {
            // Projection reduces data transfer and memory footprint
            var users = context.Users
                               .Select(u => new
                               {
                                   u.Id,
                                   u.Name,
                                   u.Email
                               })
                               .ToList();
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace QueryOptimization
{
    public class NPlusOneProblem
    {
        public void WithoutInclude(AppDbContext context)
        {
            // This can trigger N+1 queries
            var orders = context.Orders.ToList();

            foreach (var order in orders)
            {
                var customerName = order.Customer.Name;
            }
        }

        public void WithInclude(AppDbContext context)
        {
            // Eager loading avoids N+1 problem
            var orders = context.Orders
                                .Include(o => o.Customer)
                                .ToList();

            foreach (var order in orders)
            {
                var customerName = order.Customer.Name;
            }
        }
    }
}

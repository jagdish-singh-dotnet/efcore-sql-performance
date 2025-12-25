# Query Optimization with EF Core

This section focuses on common query-level optimizations when working
with Entity Framework Core in real-world applications.

The examples highlight how small changes in query design can significantly
improve performance and reduce memory usage.

## Topics Covered
- Read-only queries using AsNoTracking
- Selecting only required columns (projection)
- Avoiding the N+1 query problem
- Writing efficient and predictable LINQ queries

## Notes
The examples are intentionally simplified and focus on patterns
commonly encountered in enterprise systems.

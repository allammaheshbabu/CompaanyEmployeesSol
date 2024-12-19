using CompaanyEmployees.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CompaanyEmployees.RepositoryContextDb
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        public DbSet<Company>? Companies { get; set; }
        public DbSet<Employee>? Employees { get; set; }
    }
}
